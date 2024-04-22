using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using QuasarQuery.Logic;
using QuasarQuery.Core;
using WeifenLuo.WinFormsUI.Docking;
using QuasarQuery.Common;

namespace QuasarQuery.IDE
{
    public partial class FrmExplorer : DockContent
    {
        public FrmExplorer()
        {
            InitializeComponent();
        }

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        public void ViewSchema()
        {
            TreeNode schema = new TreeNode(ApplicationFow.CurrentConect.Name, 0, 0);
            TreeNode FolderNode = null;
            SolutionExplorerFolderCollection Folders = QuasarQuery.Core.Base.SolutionFolders();
            foreach (SolutionExplorerFolder item in Folders)
            {
                switch (item.Name)
                {
                    case Constantes.EXPLORER_FOLDER_TABLES:
                        FolderNode = new TreeNode(item.Name, 1, 1);
                        break;
                    case Constantes.EXPLORER_FOLDER_FUNCTIONS:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_CONSTRAINTS:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_DATABASE_LINK:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_DIRECTORIES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_INDEXES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_PACKAGES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_PROCEDURES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_PROFILES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_ROLES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_SEQUENCES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_SYNONYMS:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_TABLESPACES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_TRIGGERS:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_TYPES:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_USERS:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    case Constantes.EXPLORER_FOLDER_VIEWS:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                    default:
                        FolderNode = new TreeNode(item.Name, 3, 3);
                        break;
                }

                schema.Nodes.Add(FolderNode);
            }
 
            LGDataAccess lg = new LGDataAccess();
            DataBaseObject obj = lg.GetUserObjects(ApplicationFow.CurrentConect);

            foreach (TreeNode ItemNode in schema.Nodes)
            {
                switch (ItemNode.Text)
                {
                    case Constantes.EXPLORER_FOLDER_TABLES:

                        foreach (Table table in obj.Tables)
                        {
                            TreeNode TableNode = new TreeNode(table.TABLENAME, 2, 2);
                            ItemNode.Nodes.Add(TableNode);
                        }
                        break;
                    case Constantes.EXPLORER_FOLDER_PROCEDURES:
                        foreach (Procedure procedure in obj.Procedures)
                        {
                            TreeNode ProcedureNode = new TreeNode(procedure.PROCEDURENAME, 2, 2);
                            ItemNode.Nodes.Add(ProcedureNode);
                        }
                        break;
                    default:
                        break;

                    case Constantes.EXPLORER_FOLDER_FUNCTIONS:
                        foreach (Function function in obj.Functions)
                        {
                            TreeNode FunctionNode = new TreeNode(function.FUNCTIONNAME, 2, 2);
                            ItemNode.Nodes.Add(FunctionNode);
                        }
                        break;
                }
            }

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(schema);
 
        }

        private void tsmiEntityVSNET_Click(object sender, EventArgs e)
        {
            using (FrmEntity frm = new FrmEntity())
            {
                frm.ShowDialog();
            }
        }

        private void tsmiSchema_Click(object sender, EventArgs e)
        {
            using (FrmDescribeOrShema frm = new FrmDescribeOrShema())
            {             
                LGDataAccess lg = new LGDataAccess();
                if (treeView1.SelectedNode != null)
                {
                    frm.ViewResult(lg.GetSchema(ApplicationFow.CurrentConect, treeView1.SelectedNode.Text));
                }
                

            }
        }


        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (!string.IsNullOrEmpty(treeView1.SelectedNode.Text))
                {
                    if (treeView1.SelectedNode.Parent.Text == "Tables")
                    { 
                        LGDataAccess lg = new LGDataAccess();
                        string script = lg.GetScriptText(ApplicationFow.CurrentConect, QuasarQuery.Entity.Enumeradores.ETypeScript.Select, treeView1.SelectedNode.Text);
                        if (script != null)
                            treeView1.DoDragDrop(script, DragDropEffects.Copy | DragDropEffects.Move);
                        else
                            MessageBox.Show("No se puede mapear el objeto seleccionado", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);    
                    }
                }
            }
        }

        private void storeProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerateProcedure frm = new FrmGenerateProcedure();
            ApplicationFow.OpenChildren(frm);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FrmExplorer_Load(object sender, EventArgs e)
        {

        }

        private void TsmScriptSelect_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode.Parent.Text ==  Constantes.EXPLORER_FOLDER_TABLES)
            {
                
            }
        }


        private void operacionesCrudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWizardGenerationCode wTemplate = new FrmWizardGenerationCode();
            wTemplate.ShowDialog();
        }
    }
}