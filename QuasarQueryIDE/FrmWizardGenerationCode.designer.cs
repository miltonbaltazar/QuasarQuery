namespace QuasarQuery.IDE
{
    partial class FrmWizardGenerationCode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxExecute = new System.Windows.Forms.ListBox();
            this.cboTemplate = new System.Windows.Forms.ComboBox();
            this.cboProvider = new System.Windows.Forms.ComboBox();
            this.cboLanguaje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMetadata = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gvwResult = new System.Windows.Forms.DataGridView();
            this.ColumnOutputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOutputDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOutputOrdinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOutputLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvwParametros = new System.Windows.Forms.DataGridView();
            this.ColumnPrmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrmDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrmDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrmOrdinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrmPropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwParametros)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 429);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtPackage);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbxExecute);
            this.tabPage2.Controls.Add(this.cboTemplate);
            this.tabPage2.Controls.Add(this.cboProvider);
            this.tabPage2.Controls.Add(this.cboLanguaje);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtObject);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnMetadata);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.gvwResult);
            this.tabPage2.Controls.Add(this.gvwParametros);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Esquema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 339);
            this.treeView1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Paquete:";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(295, 5);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(323, 20);
            this.txtPackage.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tipo de ejecución:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Plantilla:";
            // 
            // lbxExecute
            // 
            this.lbxExecute.FormattingEnabled = true;
            this.lbxExecute.Items.AddRange(new object[] {
            "ExecuteNonQuery",
            "ExecuteReader",
            "ExecuteScalar"});
            this.lbxExecute.Location = new System.Drawing.Point(233, 70);
            this.lbxExecute.Name = "lbxExecute";
            this.lbxExecute.Size = new System.Drawing.Size(198, 43);
            this.lbxExecute.TabIndex = 42;
            // 
            // cboTemplate
            // 
            this.cboTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemplate.FormattingEnabled = true;
            this.cboTemplate.Location = new System.Drawing.Point(295, 354);
            this.cboTemplate.Name = "cboTemplate";
            this.cboTemplate.Size = new System.Drawing.Size(246, 21);
            this.cboTemplate.TabIndex = 41;
            // 
            // cboProvider
            // 
            this.cboProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvider.Enabled = false;
            this.cboProvider.FormattingEnabled = true;
            this.cboProvider.Location = new System.Drawing.Point(73, 5);
            this.cboProvider.Name = "cboProvider";
            this.cboProvider.Size = new System.Drawing.Size(153, 21);
            this.cboProvider.TabIndex = 35;
            // 
            // cboLanguaje
            // 
            this.cboLanguaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguaje.Enabled = false;
            this.cboLanguaje.FormattingEnabled = true;
            this.cboLanguaje.Location = new System.Drawing.Point(73, 27);
            this.cboLanguaje.Name = "cboLanguaje";
            this.cboLanguaje.Size = new System.Drawing.Size(153, 21);
            this.cboLanguaje.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Procedimiento almacenado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Lenguaje:";
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(375, 26);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(243, 20);
            this.txtObject.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Proveedor:";
            // 
            // btnMetadata
            // 
            this.btnMetadata.Location = new System.Drawing.Point(624, 23);
            this.btnMetadata.Name = "btnMetadata";
            this.btnMetadata.Size = new System.Drawing.Size(110, 23);
            this.btnMetadata.TabIndex = 25;
            this.btnMetadata.Text = "Mostrar Metadata";
            this.btnMetadata.UseVisualStyleBackColor = true;
            this.btnMetadata.Click += new System.EventHandler(this.btnMetadata_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Resultado";
            // 
            // gvwResult
            // 
            this.gvwResult.AllowUserToAddRows = false;
            this.gvwResult.AllowUserToDeleteRows = false;
            this.gvwResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvwResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvwResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvwResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOutputName,
            this.ColumnOutputDataType,
            this.ColumnOutputOrdinal,
            this.ColumnOutputLength});
            this.gvwResult.Location = new System.Drawing.Point(437, 70);
            this.gvwResult.Name = "gvwResult";
            this.gvwResult.RowHeadersWidth = 18;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwResult.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gvwResult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwResult.Size = new System.Drawing.Size(297, 275);
            this.gvwResult.TabIndex = 30;
            // 
            // ColumnOutputName
            // 
            this.ColumnOutputName.DataPropertyName = "Name";
            this.ColumnOutputName.HeaderText = "Resultado";
            this.ColumnOutputName.Name = "ColumnOutputName";
            this.ColumnOutputName.ReadOnly = true;
            this.ColumnOutputName.Width = 80;
            // 
            // ColumnOutputDataType
            // 
            this.ColumnOutputDataType.DataPropertyName = "DataType";
            this.ColumnOutputDataType.HeaderText = "Tipo";
            this.ColumnOutputDataType.Name = "ColumnOutputDataType";
            this.ColumnOutputDataType.ReadOnly = true;
            this.ColumnOutputDataType.Width = 52;
            // 
            // ColumnOutputOrdinal
            // 
            this.ColumnOutputOrdinal.DataPropertyName = "Ordinal";
            this.ColumnOutputOrdinal.HeaderText = "Orden";
            this.ColumnOutputOrdinal.Name = "ColumnOutputOrdinal";
            this.ColumnOutputOrdinal.ReadOnly = true;
            this.ColumnOutputOrdinal.Visible = false;
            this.ColumnOutputOrdinal.Width = 61;
            // 
            // ColumnOutputLength
            // 
            this.ColumnOutputLength.DataPropertyName = "Lenght";
            this.ColumnOutputLength.HeaderText = "Tamaño";
            this.ColumnOutputLength.Name = "ColumnOutputLength";
            this.ColumnOutputLength.ReadOnly = true;
            this.ColumnOutputLength.Visible = false;
            this.ColumnOutputLength.Width = 71;
            // 
            // gvwParametros
            // 
            this.gvwParametros.AllowUserToAddRows = false;
            this.gvwParametros.AllowUserToDeleteRows = false;
            this.gvwParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvwParametros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvwParametros.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvwParametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvwParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPrmName,
            this.ColumnPrmDataType,
            this.ColumnPrmDirection,
            this.ColumnPrmLength,
            this.ColumnPrmOrdinal,
            this.ColumnPrmPropertyValue});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvwParametros.DefaultCellStyle = dataGridViewCellStyle10;
            this.gvwParametros.Location = new System.Drawing.Point(233, 132);
            this.gvwParametros.Name = "gvwParametros";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvwParametros.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gvwParametros.RowHeadersWidth = 18;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwParametros.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gvwParametros.Size = new System.Drawing.Size(198, 213);
            this.gvwParametros.TabIndex = 28;
            // 
            // ColumnPrmName
            // 
            this.ColumnPrmName.DataPropertyName = "Name";
            this.ColumnPrmName.HeaderText = "Parametro";
            this.ColumnPrmName.Name = "ColumnPrmName";
            this.ColumnPrmName.ReadOnly = true;
            this.ColumnPrmName.Width = 81;
            // 
            // ColumnPrmDataType
            // 
            this.ColumnPrmDataType.DataPropertyName = "DataType";
            this.ColumnPrmDataType.HeaderText = "Tipo";
            this.ColumnPrmDataType.Name = "ColumnPrmDataType";
            this.ColumnPrmDataType.ReadOnly = true;
            this.ColumnPrmDataType.Width = 52;
            // 
            // ColumnPrmDirection
            // 
            this.ColumnPrmDirection.DataPropertyName = "Direction";
            this.ColumnPrmDirection.HeaderText = "Dirección";
            this.ColumnPrmDirection.Name = "ColumnPrmDirection";
            this.ColumnPrmDirection.ReadOnly = true;
            this.ColumnPrmDirection.Visible = false;
            this.ColumnPrmDirection.Width = 77;
            // 
            // ColumnPrmLength
            // 
            this.ColumnPrmLength.DataPropertyName = "Length";
            this.ColumnPrmLength.HeaderText = "Tamaño";
            this.ColumnPrmLength.Name = "ColumnPrmLength";
            this.ColumnPrmLength.ReadOnly = true;
            this.ColumnPrmLength.Visible = false;
            this.ColumnPrmLength.Width = 71;
            // 
            // ColumnPrmOrdinal
            // 
            this.ColumnPrmOrdinal.DataPropertyName = "Ordinal";
            this.ColumnPrmOrdinal.HeaderText = "Orden";
            this.ColumnPrmOrdinal.Name = "ColumnPrmOrdinal";
            this.ColumnPrmOrdinal.ReadOnly = true;
            this.ColumnPrmOrdinal.Visible = false;
            this.ColumnPrmOrdinal.Width = 61;
            // 
            // ColumnPrmPropertyValue
            // 
            this.ColumnPrmPropertyValue.DataPropertyName = "PropertyValue";
            this.ColumnPrmPropertyValue.HeaderText = "Value";
            this.ColumnPrmPropertyValue.Name = "ColumnPrmPropertyValue";
            this.ColumnPrmPropertyValue.Visible = false;
            this.ColumnPrmPropertyValue.Width = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Parametros";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbCode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(750, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Codigo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbCode
            // 
            this.rtbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCode.Location = new System.Drawing.Point(3, 3);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(744, 397);
            this.rtbCode.TabIndex = 0;
            //this.rtbCode.Text = global::CodeGen.Explorer.CodeClassConextMenu;
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(688, 492);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 28;
            this.btnAcept.Text = "Generar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(607, 492);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 29;
            this.btnView.Text = "ver";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FrmWizardGenerationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 520);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "FrmWizardGenerationCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente Generación de Código";
            this.TopDescription = "Genera codigo dinamicamente";
            this.TopTitle = "Generador de código";
            this.Load += new System.EventHandler(this.FrmWizardGenerationCode_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnAcept, 0);
            this.Controls.SetChildIndex(this.btnView, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwParametros)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvwResult;
        private System.Windows.Forms.DataGridView gvwParametros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMetadata;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cboProvider;
        private System.Windows.Forms.ComboBox cboLanguaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.ComboBox cboTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrmDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrmDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrmOrdinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrmPropertyValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOutputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOutputDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOutputOrdinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOutputLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.TreeView treeView1;
    }
}