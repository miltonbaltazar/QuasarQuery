namespace QuasarQuery.IDE
{
    partial class FrmDocument
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsDocument = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.describeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textQuery1 = new QuasarQuery.Controls.TextQuery();
            this.cmsDocument.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDocument
            // 
            this.cmsDocument.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.describeToolStripMenuItem,
            this.consultarTablaToolStripMenuItem,
            this.esquemaToolStripMenuItem});
            this.cmsDocument.Name = "cmsDocument";
            this.cmsDocument.Size = new System.Drawing.Size(155, 70);
            // 
            // describeToolStripMenuItem
            // 
            this.describeToolStripMenuItem.Name = "describeToolStripMenuItem";
            this.describeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.describeToolStripMenuItem.Text = "Describe";
            // 
            // consultarTablaToolStripMenuItem
            // 
            this.consultarTablaToolStripMenuItem.Name = "consultarTablaToolStripMenuItem";
            this.consultarTablaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.consultarTablaToolStripMenuItem.Text = "Consultar tabla";
            // 
            // esquemaToolStripMenuItem
            // 
            this.esquemaToolStripMenuItem.Name = "esquemaToolStripMenuItem";
            this.esquemaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.esquemaToolStripMenuItem.Text = "Esquema";
            // 
            // textQuery1
            // 
            this.textQuery1.CaseSensitive = false;
            this.textQuery1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textQuery1.FilterAutoComplete = false;
            this.textQuery1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery1.Location = new System.Drawing.Point(0, 0);
            this.textQuery1.MaxUndoRedoSteps = 50;
            this.textQuery1.Name = "textQuery1";
            this.textQuery1.Size = new System.Drawing.Size(610, 418);
            this.textQuery1.TabIndex = 1;
            this.textQuery1.Text = "";
            // 
            // FrmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 418);
            this.Controls.Add(this.textQuery1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FrmDocument";
            this.TabText = "FrmDocument";
            this.Text = "FrmDocument";
            this.Load += new System.EventHandler(this.FrmDocument_Load);
            this.Activated += new System.EventHandler(this.FrmDocument_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDocument_KeyDown);
            this.cmsDocument.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsDocument;
        private System.Windows.Forms.ToolStripMenuItem describeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquemaToolStripMenuItem;
        private QuasarQuery.Controls.TextQuery textQuery1;
    }
}