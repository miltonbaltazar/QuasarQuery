using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuasarQuery.Core;

namespace QuasarQuery.IDE
{
    public partial class FrmDescribeOrShema : Form
    {
        public FrmDescribeOrShema()
        {
            InitializeComponent();
        }

        private void FrmDescribeOrShema_Load(object sender, EventArgs e)
        {

        }

        public void ViewResult(DataTable pTable)
        {
            dataGridView1.DataSource = pTable;
            this.ShowDialog();
        }
    }
}