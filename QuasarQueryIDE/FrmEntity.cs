using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuasarQuery.IDE
{
    public partial class FrmEntity : Form
    {
        public FrmEntity()
        {
            InitializeComponent();
        }


        private void FrmEntity_Load(object sender, EventArgs e)
        {
            try
            {
                ColumnType.DataSource = QuasarQuery.Core.Base.DataTypes("Oracle");
                ColumnType.DataPropertyName = "";
                ColumnType.ValueMember = "Name";
                ColumnType.DisplayMember = "Name";

                cboLenguaje.DataSource = QuasarQuery.Core.Base.Languajes();
                cboLenguaje.ValueMember = "Value";
                cboLenguaje.DisplayMember = "Name";
            }
            catch(Exception ex)
            { 
            }
        }
    }
}