namespace QuasarQuery.IDE
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboHome = new System.Windows.Forms.ComboBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOracle = new System.Windows.Forms.TabPage();
            this.cboHomeRefresh = new System.Windows.Forms.Button();
            this.tpProperties = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.cboProvider = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvConnections = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbAddConnection = new System.Windows.Forms.ToolStripButton();
            this.txtIdSession = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpOracle.SuspendLayout();
            this.tpProperties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(269, 386);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 27);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Aceptar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(369, 386);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 27);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(116, 173);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(203, 20);
            this.txtUser.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(116, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(203, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // cboServer
            // 
            this.cboServer.Location = new System.Drawing.Point(116, 97);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(203, 21);
            this.cboServer.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Remember password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkIntegratedSecurity
            // 
            this.chkIntegratedSecurity.AutoSize = true;
            this.chkIntegratedSecurity.Location = new System.Drawing.Point(116, 150);
            this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
            this.chkIntegratedSecurity.Size = new System.Drawing.Size(115, 17);
            this.chkIntegratedSecurity.TabIndex = 4;
            this.chkIntegratedSecurity.Text = "Integrated Security";
            this.chkIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkIntegratedSecurity_CheckedChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(15, 386);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 27);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Probar";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(469, 386);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(94, 27);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboHome
            // 
            this.cboHome.Location = new System.Drawing.Point(116, 68);
            this.cboHome.Name = "cboHome";
            this.cboHome.Size = new System.Drawing.Size(167, 21);
            this.cboHome.TabIndex = 2;
            this.cboHome.SelectedIndexChanged += new System.EventHandler(this.cboHome_SelectedIndexChanged);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(22, 72);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(35, 13);
            this.lblHome.TabIndex = 33;
            this.lblHome.Text = "Home";
            // 
            // txtDataBase
            // 
            this.txtDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataBase.Location = new System.Drawing.Point(116, 124);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(203, 20);
            this.txtDataBase.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data base:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOracle);
            this.tabControl1.Controls.Add(this.tpProperties);
            this.tabControl1.Location = new System.Drawing.Point(215, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 320);
            this.tabControl1.TabIndex = 37;
            // 
            // tpOracle
            // 
            this.tpOracle.Controls.Add(this.txtIdSession);
            this.tpOracle.Controls.Add(this.label5);
            this.tpOracle.Controls.Add(this.label6);
            this.tpOracle.Controls.Add(this.cboProvider);
            this.tpOracle.Controls.Add(this.txtUser);
            this.tpOracle.Controls.Add(this.cboHome);
            this.tpOracle.Controls.Add(this.label1);
            this.tpOracle.Controls.Add(this.txtPassword);
            this.tpOracle.Controls.Add(this.cboHomeRefresh);
            this.tpOracle.Controls.Add(this.label2);
            this.tpOracle.Controls.Add(this.lblHome);
            this.tpOracle.Controls.Add(this.txtDataBase);
            this.tpOracle.Controls.Add(this.checkBox1);
            this.tpOracle.Controls.Add(this.cboServer);
            this.tpOracle.Controls.Add(this.label4);
            this.tpOracle.Controls.Add(this.label3);
            this.tpOracle.Controls.Add(this.chkIntegratedSecurity);
            this.tpOracle.Location = new System.Drawing.Point(4, 22);
            this.tpOracle.Name = "tpOracle";
            this.tpOracle.Padding = new System.Windows.Forms.Padding(3);
            this.tpOracle.Size = new System.Drawing.Size(384, 294);
            this.tpOracle.TabIndex = 0;
            this.tpOracle.Text = "Connection";
            this.tpOracle.UseVisualStyleBackColor = true;
            // 
            // cboHomeRefresh
            // 
            this.cboHomeRefresh.Location = new System.Drawing.Point(288, 63);
            this.cboHomeRefresh.Name = "cboHomeRefresh";
            this.cboHomeRefresh.Size = new System.Drawing.Size(34, 31);
            this.cboHomeRefresh.TabIndex = 39;
            this.cboHomeRefresh.UseVisualStyleBackColor = true;
            this.cboHomeRefresh.Click += new System.EventHandler(this.cboHomeRefresh_Click);
            // 
            // tpProperties
            // 
            this.tpProperties.Controls.Add(this.propertyGrid1);
            this.tpProperties.Location = new System.Drawing.Point(4, 22);
            this.tpProperties.Name = "tpProperties";
            this.tpProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tpProperties.Size = new System.Drawing.Size(384, 294);
            this.tpProperties.TabIndex = 2;
            this.tpProperties.Text = "Properties";
            this.tpProperties.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(378, 288);
            this.propertyGrid1.TabIndex = 0;
            // 
            // cboProvider
            // 
            this.cboProvider.Location = new System.Drawing.Point(116, 15);
            this.cboProvider.Name = "cboProvider";
            this.cboProvider.Size = new System.Drawing.Size(167, 21);
            this.cboProvider.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Provider";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvConnections);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 320);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections";
            // 
            // trvConnections
            // 
            this.trvConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvConnections.Location = new System.Drawing.Point(3, 39);
            this.trvConnections.Name = "trvConnections";
            this.trvConnections.Size = new System.Drawing.Size(188, 278);
            this.trvConnections.TabIndex = 14;
            this.trvConnections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvConnections_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDelete,
            this.tsbAddConnection});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(188, 23);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::QuasarQuery.IDE.Properties.Resources.db_remove;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 20);
            this.tsbDelete.Text = "toolStripButton1";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbAddConnection
            // 
            this.tsbAddConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddConnection.Image = global::QuasarQuery.IDE.Properties.Resources.db_add;
            this.tsbAddConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddConnection.Name = "tsbAddConnection";
            this.tsbAddConnection.Size = new System.Drawing.Size(23, 20);
            this.tsbAddConnection.Text = "toolStripButton1";
            this.tsbAddConnection.Click += new System.EventHandler(this.tsbAddConnection_Click);
            // 
            // txtIdSession
            // 
            this.txtIdSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdSession.Location = new System.Drawing.Point(116, 42);
            this.txtIdSession.Name = "txtIdSession";
            this.txtIdSession.Size = new System.Drawing.Size(262, 20);
            this.txtIdSession.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Id session:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Establecer conexión";
            this.TopDescription = "Establece la conección a la base de datos.";
            this.TopTitle = "Establecer conección";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.btnConnect, 0);
            this.Controls.SetChildIndex(this.btnTest, 0);
            this.Controls.SetChildIndex(this.btnGrabar, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tpOracle.ResumeLayout(false);
            this.tpOracle.PerformLayout();
            this.tpProperties.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkIntegratedSecurity;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cboHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOracle;
        private System.Windows.Forms.Button cboHomeRefresh;
        private System.Windows.Forms.TabPage tpProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ComboBox cboProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TreeView trvConnections;
        private System.Windows.Forms.ToolStripButton tsbAddConnection;
        private System.Windows.Forms.TextBox txtIdSession;
        private System.Windows.Forms.Label label6;
    }
}