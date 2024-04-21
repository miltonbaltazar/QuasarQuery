namespace QuasarQuery.IDE
{
    partial class FrmExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExplorer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cmsExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDescribe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmScriptSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmScriptInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmScriptUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmScriptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.entityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntityVSNET = new System.Windows.Forms.ToolStripMenuItem();
            this.getTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.geToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarBackEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesCrudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.cmsExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(245, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConnect
            // 
            this.tsbConnect.Image = global::QuasarQuery.IDE.Properties.Resources.connect_creating;
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(72, 22);
            this.tsbConnect.Text = "Connect";
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::QuasarQuery.IDE.Properties.Resources.connect_no;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton1.Text = "Disconnect";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ContextMenuStrip = this.cmsExplorer;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imlIcons;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(245, 447);
            this.treeView1.TabIndex = 1;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // cmsExplorer
            // 
            this.cmsExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.tsmiDescribe,
            this.tsmiSchema,
            this.toolStripMenuItem1,
            this.scriptToolStripMenuItem,
            this.viewDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.entityToolStripMenuItem,
            this.getTemplateToolStripMenuItem,
            this.toolStripMenuItem3,
            this.geToolStripMenuItem,
            this.generarBackEndToolStripMenuItem,
            this.fullStackToolStripMenuItem});
            this.cmsExplorer.Name = "cmsExplorer";
            this.cmsExplorer.Size = new System.Drawing.Size(184, 280);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // tsmiDescribe
            // 
            this.tsmiDescribe.Name = "tsmiDescribe";
            this.tsmiDescribe.Size = new System.Drawing.Size(183, 22);
            this.tsmiDescribe.Text = "Describir";
            // 
            // tsmiSchema
            // 
            this.tsmiSchema.Image = global::QuasarQuery.IDE.Properties.Resources.box;
            this.tsmiSchema.Name = "tsmiSchema";
            this.tsmiSchema.Size = new System.Drawing.Size(183, 22);
            this.tsmiSchema.Text = "Esquema";
            this.tsmiSchema.Click += new System.EventHandler(this.tsmiSchema_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmScriptSelect,
            this.TsmScriptInsert,
            this.TsmScriptUpdate,
            this.TsmScriptDelete});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // TsmScriptSelect
            // 
            this.TsmScriptSelect.Name = "TsmScriptSelect";
            this.TsmScriptSelect.Size = new System.Drawing.Size(112, 22);
            this.TsmScriptSelect.Text = "Select";
            this.TsmScriptSelect.Click += new System.EventHandler(this.TsmScriptSelect_Click);
            // 
            // TsmScriptInsert
            // 
            this.TsmScriptInsert.Name = "TsmScriptInsert";
            this.TsmScriptInsert.Size = new System.Drawing.Size(112, 22);
            this.TsmScriptInsert.Text = "Insert";
            // 
            // TsmScriptUpdate
            // 
            this.TsmScriptUpdate.Name = "TsmScriptUpdate";
            this.TsmScriptUpdate.Size = new System.Drawing.Size(112, 22);
            this.TsmScriptUpdate.Text = "Update";
            // 
            // TsmScriptDelete
            // 
            this.TsmScriptDelete.Name = "TsmScriptDelete";
            this.TsmScriptDelete.Size = new System.Drawing.Size(112, 22);
            this.TsmScriptDelete.Text = "Delete";
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewDataToolStripMenuItem.Text = "View Data";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // entityToolStripMenuItem
            // 
            this.entityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntityVSNET});
            this.entityToolStripMenuItem.Name = "entityToolStripMenuItem";
            this.entityToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.entityToolStripMenuItem.Text = "Entity";
            // 
            // tsmiEntityVSNET
            // 
            this.tsmiEntityVSNET.Name = "tsmiEntityVSNET";
            this.tsmiEntityVSNET.Size = new System.Drawing.Size(167, 22);
            this.tsmiEntityVSNET.Text = "Visual Studio .Net";
            this.tsmiEntityVSNET.Click += new System.EventHandler(this.tsmiEntityVSNET_Click);
            // 
            // getTemplateToolStripMenuItem
            // 
            this.getTemplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeProcedureToolStripMenuItem});
            this.getTemplateToolStripMenuItem.Name = "getTemplateToolStripMenuItem";
            this.getTemplateToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.getTemplateToolStripMenuItem.Text = "Generation Template";
            // 
            // storeProcedureToolStripMenuItem
            // 
            this.storeProcedureToolStripMenuItem.Name = "storeProcedureToolStripMenuItem";
            this.storeProcedureToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.storeProcedureToolStripMenuItem.Text = "Store Procedure";
            this.storeProcedureToolStripMenuItem.Click += new System.EventHandler(this.storeProcedureToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 22);
            // 
            // geToolStripMenuItem
            // 
            this.geToolStripMenuItem.Name = "geToolStripMenuItem";
            this.geToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            // 
            // generarBackEndToolStripMenuItem
            // 
            this.generarBackEndToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesCrudToolStripMenuItem});
            this.generarBackEndToolStripMenuItem.Name = "generarBackEndToolStripMenuItem";
            this.generarBackEndToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.generarBackEndToolStripMenuItem.Text = "BackEnd";
            // 
            // operacionesCrudToolStripMenuItem
            // 
            this.operacionesCrudToolStripMenuItem.Name = "operacionesCrudToolStripMenuItem";
            this.operacionesCrudToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.operacionesCrudToolStripMenuItem.Text = "crud operations";
            this.operacionesCrudToolStripMenuItem.Click += new System.EventHandler(this.operacionesCrudToolStripMenuItem_Click);
            // 
            // fullStackToolStripMenuItem
            // 
            this.fullStackToolStripMenuItem.Name = "fullStackToolStripMenuItem";
            this.fullStackToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fullStackToolStripMenuItem.Text = "FullStack";
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "server.png");
            this.imlIcons.Images.SetKeyName(1, "tables.gif");
            this.imlIcons.Images.SetKeyName(2, "kdb_table.png");
            this.imlIcons.Images.SetKeyName(3, "folder.gif");
            // 
            // FrmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 472);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmExplorer";
            this.TabText = "Server explorer";
            this.Text = "Server explorer";
            this.Load += new System.EventHandler(this.FrmExplorer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsExplorer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip cmsExplorer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDescribe;
        private System.Windows.Forms.ToolStripMenuItem tsmiSchema;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmScriptSelect;
        private System.Windows.Forms.ToolStripMenuItem TsmScriptInsert;
        private System.Windows.Forms.ToolStripMenuItem TsmScriptUpdate;
        private System.Windows.Forms.ToolStripMenuItem TsmScriptDelete;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntityVSNET;
        private System.Windows.Forms.ToolStripMenuItem getTemplateToolStripMenuItem;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.ToolStripMenuItem storeProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem geToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarBackEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesCrudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullStackToolStripMenuItem;
    }
}