namespace QuasarQuery.IDE
{
    partial class FrmCompareDataBase
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
            this.btnComparerBD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbC = new System.Windows.Forms.RichTextBox();
            this.txtBdA = new System.Windows.Forms.TextBox();
            this.txtBdB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbA = new System.Windows.Forms.RichTextBox();
            this.rtbB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComparerBD
            // 
            this.btnComparerBD.Location = new System.Drawing.Point(681, 503);
            this.btnComparerBD.Name = "btnComparerBD";
            this.btnComparerBD.Size = new System.Drawing.Size(99, 23);
            this.btnComparerBD.TabIndex = 0;
            this.btnComparerBD.Text = "Comparar";
            this.btnComparerBD.UseVisualStyleBackColor = true;
            this.btnComparerBD.Click += new System.EventHandler(this.btnComparerBD_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbC
            // 
            this.rtbC.Location = new System.Drawing.Point(598, 127);
            this.rtbC.Name = "rtbC";
            this.rtbC.Size = new System.Drawing.Size(287, 359);
            this.rtbC.TabIndex = 2;
            this.rtbC.Text = "";
            // 
            // txtBdA
            // 
            this.txtBdA.Location = new System.Drawing.Point(252, 32);
            this.txtBdA.Name = "txtBdA";
            this.txtBdA.Size = new System.Drawing.Size(463, 20);
            this.txtBdA.TabIndex = 3;
            // 
            // txtBdB
            // 
            this.txtBdB.Location = new System.Drawing.Point(252, 58);
            this.txtBdB.Name = "txtBdB";
            this.txtBdB.Size = new System.Drawing.Size(463, 20);
            this.txtBdB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "BASE DATOS BASE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NO INCLUIR OBJETOS DE BASE DE DATOS:";
            // 
            // rtbA
            // 
            this.rtbA.Location = new System.Drawing.Point(12, 127);
            this.rtbA.Name = "rtbA";
            this.rtbA.Size = new System.Drawing.Size(287, 359);
            this.rtbA.TabIndex = 7;
            this.rtbA.Text = "";
            // 
            // rtbB
            // 
            this.rtbB.Location = new System.Drawing.Point(305, 127);
            this.rtbB.Name = "rtbB";
            this.rtbB.Size = new System.Drawing.Size(287, 359);
            this.rtbB.TabIndex = 8;
            this.rtbB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "OBJETOS BASE DE DATOS BASE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "OBJETOS BASE DATOS NO INCLUIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OBJETOS NUEVOS";
            // 
            // FrmCompareDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbB);
            this.Controls.Add(this.rtbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBdB);
            this.Controls.Add(this.txtBdA);
            this.Controls.Add(this.rtbC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComparerBD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCompareDataBase";
            this.Text = "FrmCompareDataBase";
            this.Load += new System.EventHandler(this.FrmCompareDataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComparerBD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbC;
        private System.Windows.Forms.TextBox txtBdA;
        private System.Windows.Forms.TextBox txtBdB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbA;
        private System.Windows.Forms.RichTextBox rtbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}