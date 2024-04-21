namespace QuasarQuery.IDE
{
    partial class FrmEntity
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboLenguaje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeafultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBaseDatos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnName,
            this.DeafultValue,
            this.Comment});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(11, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cboLenguaje
            // 
            this.cboLenguaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLenguaje.FormattingEnabled = true;
            this.cboLenguaje.Location = new System.Drawing.Point(71, 12);
            this.cboLenguaje.Name = "cboLenguaje";
            this.cboLenguaje.Size = new System.Drawing.Size(166, 21);
            this.cboLenguaje.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lenguaje";
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Column Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Column Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // DeafultValue
            // 
            this.DeafultValue.HeaderText = "Default";
            this.DeafultValue.Name = "DeafultValue";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BD";
            // 
            // cboBaseDatos
            // 
            this.cboBaseDatos.FormattingEnabled = true;
            this.cboBaseDatos.Location = new System.Drawing.Point(71, 39);
            this.cboBaseDatos.Name = "cboBaseDatos";
            this.cboBaseDatos.Size = new System.Drawing.Size(166, 21);
            this.cboBaseDatos.TabIndex = 5;
            // 
            // FrmEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBaseDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLenguaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmEntity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Entidades";
            this.Load += new System.EventHandler(this.FrmEntity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboLenguaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeafultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBaseDatos;
    }
}