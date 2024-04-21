using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using QuasarQuery.Controls;
using WeifenLuo.WinFormsUI.Docking;

namespace QuasarQuery.IDE
{
    public partial class FrmDocument : DockContent
    {
        public FrmDocument()
        {
            InitializeComponent();
        }

        public string[] GetQuerySelect()
        {
            string[] values;
            char[] delimiters = new char[] { '\r', '\n' };

            if (string.IsNullOrEmpty(textQuery1.SelectedText.Trim()))
            {

                values = textQuery1.Text.Split(delimiters);
            }
            else
            {
                values = textQuery1.SelectedText.Split(delimiters);
            }
            return values;
        }

        private void FrmDocument_Load(object sender, EventArgs e)
        {
            textQuery1.AllowDrop = true;
            textQuery1.Seperators.Add(' ');
            textQuery1.Seperators.Add('\r');
            textQuery1.Seperators.Add('\n');
            textQuery1.Seperators.Add(',');
            textQuery1.Seperators.Add('.');
            textQuery1.Seperators.Add('-');
            textQuery1.Seperators.Add('+');
            textQuery1.Seperators.Add('*');
            textQuery1.Seperators.Add('/');

            textQuery1.FilterAutoComplete = true;

            textQuery1.HighlightDescriptors.Add(new HighlightDescriptor("Select", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
            textQuery1.HighlightDescriptors.Add(new HighlightDescriptor("From", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
            textQuery1.HighlightDescriptors.Add(new HighlightDescriptor("Table", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
            textQuery1.HighlightDescriptors.Add(new HighlightDescriptor("World", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
            textQuery1.HighlightDescriptors.Add(new HighlightDescriptor("/*", "*/", Color.Green, null, DescriptorType.ToCloseToken, DescriptorRecognition.StartsWith, false));

        }

        private void FrmDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ApplicationFow.ShowResult();
            }
            else if (e.Control)
            {
                if (e.KeyCode == Keys.R)
                {
                    if (ApplicationFow.Result.IsHidden)
                    {
                        ApplicationFow.Result.Show();
                    }
                    else
                    {
                        ApplicationFow.Result.Hide();
                    }
                    this.Focus();
                }
            }
        }

        private void FrmDocument_Activated(object sender, EventArgs e)
        {
            ApplicationFow.CurrentDocument = this;
        }

        public void SetSext(string ptext)
        {
            textQuery1.Text = ptext;
        }

        
 
    }
}