namespace QuasarQuery.IDE
{
    partial class FrmTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.trvTemplates = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fctb
            // 
            this.fctb.AllowDrop = true;
            this.fctb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fctb.BackBrush = null;
            this.fctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctb.LeftBracket = '(';
            this.fctb.Location = new System.Drawing.Point(253, 89);
            this.fctb.Name = "fctb";
            this.fctb.Paddings = new System.Windows.Forms.Padding(0);
            this.fctb.RightBracket = ')';
            this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctb.Size = new System.Drawing.Size(556, 324);
            this.fctb.TabIndex = 4;
            this.fctb.WordWrap = true;
            this.fctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctb_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(734, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Grabar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trvTemplates
            // 
            this.trvTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trvTemplates.HideSelection = false;
            this.trvTemplates.Location = new System.Drawing.Point(6, 89);
            this.trvTemplates.Name = "trvTemplates";
            this.trvTemplates.Size = new System.Drawing.Size(241, 353);
            this.trvTemplates.TabIndex = 8;
            this.trvTemplates.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvTemplates_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trvTemplates);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.fctb);
            this.KeyPreview = true;
            this.Name = "FrmTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantilla";
            this.TopDescription = "Seleccione la plantilla y en el contenedor derecho se mostrara su código";
            this.TopTitle = "EDITOR DE PLANTILLAS";
            this.Load += new System.EventHandler(this.FrmTemplate_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTemplate_FormClosing);
            this.Controls.SetChildIndex(this.fctb, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.trvTemplates, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TreeView trvTemplates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}