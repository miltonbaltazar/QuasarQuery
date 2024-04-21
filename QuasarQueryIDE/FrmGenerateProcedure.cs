using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace QuasarQuery.IDE
{
    public partial class FrmGenerateProcedure : DockContent
    {
        public FrmGenerateProcedure()
        {
            InitializeComponent();
        }

        private void FrmGenerateProcedure_Load(object sender, EventArgs e)
        {
            ParameterType.DataSource = QuasarQuery.Core.Base.DataTypes("Oracle");
            ParameterType.ValueMember = "Name";
            ParameterType.DisplayMember = "Name";


        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

    }
}
