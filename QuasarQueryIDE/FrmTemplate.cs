using System;
using System.Collections.Generic;
using System.ComponentModel;
using FastColoredTextBoxNS;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using QuasarQuery.Common;
namespace QuasarQuery.IDE
{
    public partial class FrmTemplate : FrmReset
    {
        private string CurrentFilePath = string.Empty;
        TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Italic);

        public FrmTemplate()
        {
            InitializeComponent();
            this.fctb.DescriptionFile = Path.Combine(Environment.CurrentDirectory, @"Mapper\htmlDesc.xml");
        }

        private void FrmTemplate_Load(object sender, EventArgs e)
        {
            DirectoryInfo TemplateDirectory = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"Mapper\Templates"));
            TreeNode trnTemplate = new TreeNode();
            TreeNode trnDirectory;
            TreeNode trnFile;

            trnTemplate.Name = "Templates";
            trnTemplate.Text = "Templates";

            foreach (DirectoryInfo info in TemplateDirectory.GetDirectories())
            {
                trnDirectory = new TreeNode();
                trnDirectory.Text = info.Name;
                foreach(FileInfo files in info.GetFiles())
                {
                    trnFile = new TreeNode();
                    trnFile.Text = files.Name;
                    trnFile.Tag = files.FullName;
                    trnDirectory.Nodes.Add(trnFile);
                }
                trnTemplate.Nodes.Add(trnDirectory);
            }
            trnTemplate.ExpandAll();
            trvTemplates.Nodes.Add(trnTemplate);
        }

        private void trvTemplates_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.fctb.CloseBindingFile();
            if (e.Node.Level == 2)
            {
                CurrentFilePath = e.Node.Tag.ToString();
                fctb.OpenBindingFile(CurrentFilePath, Encoding.UTF8);
                fctb.IsChanged = false;
                fctb.ClearUndo();
                GC.Collect();
                GC.GetTotalMemory(true);

                fctb.OnTextChanged();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.fctb.SaveToFile(CurrentFilePath, Encoding.UTF8);
        }

        private void FrmTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            fctb.CloseBindingFile();
        }

        private void fctb_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            //e.ChangedRange.ClearStyle(MaroonStyle);
            //e.ChangedRange.SetStyle(MaroonStyle, @"\b(xsl:stylesheet|xsl:template|xsl:variable|xsl:choose|xsl:when|xsl:for-each|xsl:if|xsl:value-of)\b", RegexOptions.Singleline);

            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers(@"<xsl:choose>", @"</xsl:choose>");
        }
         
    }
}
