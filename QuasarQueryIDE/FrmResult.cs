using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using WeifenLuo.WinFormsUI.Docking;

namespace QuasarQuery.IDE
{
    public partial class FrmResult : DockContent
    {
        public FrmResult()
        {
            InitializeComponent();
        }

        public void SetDataSource(DataTable dt)
        {
            gridViewResult1.DataSource = dt;
        }
    }
}