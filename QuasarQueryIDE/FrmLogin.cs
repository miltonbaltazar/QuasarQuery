using System;
using QuasarQuery.Entity;
using QuasarQuery.Logic;
using QuasarQuery.Common;
using QuasarQuery.Core;
using System.Windows.Forms;


namespace QuasarQuery.IDE
{
    public partial class FrmLogin : FrmReset
    {
        Session session = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            string strmsg = string.Empty;
            session = setSession();
            ConnectDataBase(session);
            if (!session.isValid(out strmsg))
            {
                MessageBox.Show(strmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtBd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Session session = setSession();
                ConnectDataBase(session);
            }
        }

        private void ConnectDataBase(Session session)
        {
            LGDataAccess lg = new LGDataAccess();
            using (ValidateResult result = lg.SetConnect(ref session))
            {
                if (session.ConnectResult == QuasarQuery.Entity.Enumeradores.EConnectResult.Correct)
                {
                    ApplicationFow.AddOrMergeConnect(session);
                    ApplicationFow.ShowUserObjects();
                    this.Close();
                }
                else
                {
                    ApplicationFow.ShowMessage(result);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DataBaseCollection databases = CodeDeveloperGetter.GetDataBaseCollection();
            cboProvider.DataSource = databases;
            cboProvider.ValueMember = "EnumName";
            cboProvider.DisplayMember = "Name";

            TreeNode ConnectionsNode = null;
            foreach (DataBaseObject database in databases)
            {
                if (database.EnumKey != EnumProviders.None)
                {
                    ConnectionsNode = new TreeNode(database.Name, 1, 1);
                    ConnectionsNode.ExpandAll();
                    foreach (Session sess in ApplicationFow.GetSessions().FindAll(c=> c.Provider == database.EnumKey))
                    {
                        string name = string.Empty;
                        if (string.IsNullOrEmpty(sess.Name))
                            name = "<none>";
                        else
                            name = sess.Name;

                        ConnectionsNode.Nodes.Add(sess.Id.ToString(), name);
                    } 
                    trvConnections.Nodes.Add(ConnectionsNode);
                }
            }
            

        }

        public Session setSession()
        {
            session  = new Session() 
            {
                Id = (string.IsNullOrEmpty(txtIdSession.Text)) ? Guid.NewGuid().ToString() : txtIdSession.Text,
                DataSource = txtDataBase.Text,
                Server = cboServer.Text,
                IntegratedSecurity = chkIntegratedSecurity.Checked,
                Password = (chkIntegratedSecurity.Checked) ? string.Empty : txtPassword.Text,
                User = (chkIntegratedSecurity.Checked) ? string.Empty : txtUser.Text,
                Name = string.Concat(cboServer.Text, "@", txtUser.Text),
                Provider = (cboProvider.SelectedValue.ToString() == "Oracle") ? EnumProviders.Oracle : EnumProviders.SQLServer 
            };
            propertyGrid1.SelectedObject = session;
            return session;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string strmsg = string.Empty;
            session = setSession();
            if (!session.isValid(out strmsg))
            {
                MessageBox.Show(strmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            LogicDataAccessGetter dal = new LogicDataAccessGetter();
            DataBaseObject database = (DataBaseObject)cboProvider.SelectedItem;
            ValidateResult Success = dal.TestConnect((EnumProviders)database.EnumKey, session);

            if (!(Success.Estado == eTypeResult.Confirmacion))
            {
                MessageBox.Show(Success.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LGDataAccess lg = new LGDataAccess();
            using (ValidateResult result = lg.SetConnect(ref session))
            {                    
                ApplicationFow.ShowMessage(result);                   
            }
        
        }
 
        private void cboHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboServer.DataSource = new TNSNamesReader().LoadTNSNames((string)cboHome.SelectedValue);
        }

        private void SetConnect(Session pSession)
        {
            session = pSession;
            txtIdSession.Text = session.Id;
            txtDataBase.Text = session.DataSource;
            txtUser.Text = session.User;
            cboServer.Text = session.Server;
            txtPassword.Text = session.Password;
            //txtName.Text = session.ConnectionName;
            checkBox1.Checked = session.RememberPassword;
            propertyGrid1.SelectedObject = session;
            cboProvider.SelectedValue = Enum.GetName(typeof(EnumProviders), session.Provider);
        }
 

        private void chkIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {         
            txtUser.Enabled = !chkIntegratedSecurity.Checked;
            txtPassword.Enabled = !chkIntegratedSecurity.Checked;
          
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ApplicationFow.AddOrMergeConnect(setSession());
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (trvConnections.SelectedNode.Level == 1)
            {
                string id = trvConnections.SelectedNode.Name;
                trvConnections.SelectedNode.Remove();
                ApplicationFow.RemoveSession(id);
            }
        }

        private void cboHomeRefresh_Click(object sender, EventArgs e)
        {
            cboHome.DataSource = new TNSNamesReader().GetOracleHomes();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (trvConnections.SelectedNode.Level == 1)
            {
                string id = trvConnections.SelectedNode.Name;
                trvConnections.SelectedNode.Remove();
                ApplicationFow.RemoveSession(id);
            }
        }

        private void trvConnections_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SetConnect(ApplicationFow.GetSession(trvConnections.SelectedNode.Name));
        }

        private void tsbAddConnection_Click(object sender, EventArgs e)
        {
            txtIdSession.Text = string.Empty;
            txtDataBase.Text = string.Empty;
            txtUser.Text = string.Empty;
            cboServer.Text = string.Empty;
            txtPassword.Text = string.Empty;
            checkBox1.Checked = false;
            propertyGrid1.SelectedObject = null;
            cboProvider.SelectedValue = string.Empty;
            tabControl1.SelectedIndex = 0;
            trvConnections.SelectedNode = null;
            session = null;
        }
    }
}