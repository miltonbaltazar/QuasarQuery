using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuasarQuery.IDE
{
    public partial class FrmValidarExpresionesRegulares : Form
    {
        public FrmValidarExpresionesRegulares()
        {
            InitializeComponent();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            label1.Text = (Regex.IsMatch(richTextBox1.Text, textBox1.Text))? "Valido" : "Inválido";
        }
    }
}
