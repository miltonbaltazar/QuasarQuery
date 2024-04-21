using QuasarQuery.Controls;
namespace QuasarQuery.IDE
{
    partial class FrmParametersCollection
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
            this.gridViewResult1 = new QuasarQuery.Controls.GridViewResult();
            this.Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewResult1
            // 
            this.gridViewResult1.BackgroundColor = System.Drawing.Color.White;
            this.gridViewResult1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResult1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parametro,
            this.Tipo});
            this.gridViewResult1.Location = new System.Drawing.Point(2, 2);
            this.gridViewResult1.Name = "gridViewResult1";
            this.gridViewResult1.Size = new System.Drawing.Size(370, 364);
            this.gridViewResult1.TabIndex = 0;
            // 
            // Parametro
            // 
            this.Parametro.HeaderText = "Parametros";
            this.Parametro.Name = "Parametro";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmParametersCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 378);
            this.Controls.Add(this.gridViewResult1);
            this.Name = "FrmParametersCollection";
            this.Text = "Parametros";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridViewResult gridViewResult1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
    }
}