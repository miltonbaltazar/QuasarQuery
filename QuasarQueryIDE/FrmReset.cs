using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuasarQuery.IDE
{
    public partial class FrmReset : Form
    {
        public FrmReset()
        {
            InitializeComponent();
        }

        private void FrmReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void FrmReset_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        public string TopTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string TopDescription
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }
    }
}
