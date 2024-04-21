using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuasarQuery.IDE
{
    public partial class frmResultCode : Form
    {
        public void SetText(string pCode)
        {
         fctb.Text = pCode;
        }
        public frmResultCode()
        {
            InitializeComponent();
        }

        private void frmResultCode_Load(object sender, EventArgs e)
        {

        }
    }
}
