using QuasarQuery.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
namespace QuasarQuery.IDE
{
    public partial class WinQuasarQueryUI :   Form
    {
        public WinQuasarQueryUI()
        {
            InitializeComponent();
        }

        private void FrmOracleUI_Load(object sender, EventArgs e)
        {
            dockPanel1.Dock = DockStyle.Fill;
            dockPanel1.BackColor = Color.Beige;
            dockPanel1.BringToFront();

            ApplicationFow.OpenExplorer();
            ApplicationFow.GetSessions();


        }
       
        private void tsbNewQuery_Click(object sender, EventArgs e)
        {
            ApplicationFow.OpenDocument();

        }

        private void tsbExecute_Click(object sender, EventArgs e)
        {
            ApplicationFow.ShowResult();
        }

        private void tsmiValidarER_Click(object sender, EventArgs e)
        {
            FrmValidarExpresionesRegulares frmval = new FrmValidarExpresionesRegulares();
            frmval.ShowDialog();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compararBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationFow.OpenCompareBd();
        }

        private void templateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTemplate wTemplate = new FrmTemplate();
            wTemplate.ShowDialog();
        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWizardGenerationCode wTemplate = new FrmWizardGenerationCode();
            wTemplate.ShowDialog();
        }
         
    }
}