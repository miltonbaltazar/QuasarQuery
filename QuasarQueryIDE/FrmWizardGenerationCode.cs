using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.IO;
using System.Xml;
using System.Windows.Documents;
using QuasarQuery.Core;
using QuasarQuery.Logic;
using QuasarQuery.Common;


namespace QuasarQuery.IDE
{
    public partial class FrmWizardGenerationCode : FrmReset
    {
        Procedure procedure = null;

        public FrmWizardGenerationCode()
        {
            InitializeComponent();
        }
 

        private static Dictionary<String, XslCompiledTransform> cachedTransforms = new Dictionary<string, XslCompiledTransform>();
        private static XslCompiledTransform GetAndCacheTransform(String xslt)
        {
            XslCompiledTransform transform;
            if (!cachedTransforms.TryGetValue(xslt, out transform))
            {
                transform = new XslCompiledTransform();
                using (XmlReader reader = XmlReader.Create(new StringReader(xslt)))
                {
                    transform.Load(reader);
                }
                cachedTransforms.Add(xslt, transform);
            }
            return transform;
        }

        private void FrmWizardGenerationCode_Load(object sender, EventArgs e)
        {
            gvwParametros.AutoGenerateColumns = false;
            gvwResult.AutoGenerateColumns = false;

            DataBaseCollection databases = CodeDeveloperGetter.GetDataBaseCollection();
            DataBaseObject item = new DataBaseObject();
            item.EnumKey = 0;
            item.ConnectionString = string.Empty;
            item.Name = "(Seleccione)";
            databases.Insert(0, item);

            cboProvider.DataSource = databases;
            cboProvider.ValueMember = "EnumName";
            cboProvider.DisplayMember = "Name";

            LanguajeCollection LanguajeList = CodeDeveloperGetter.GetLanguajesCollection();
            Languaje LanguajeItem = new Languaje();
            LanguajeItem.Value = "";
            LanguajeItem.Name = "(Seleccione)";
            LanguajeList.Insert(0, LanguajeItem);

            cboLanguaje.DataSource = LanguajeList;
            cboLanguaje.ValueMember = "Value";
            cboLanguaje.DisplayMember = "Name";

            ElementCollection TemplateList = CodeDeveloperGetter.GetTemplates(EnumTypeTemplate.StoreProcedure);
            Element TemplateItem = new Element();
            TemplateItem.Value = "";
            TemplateItem.Name = "(Seleccione)";
            TemplateList.Insert(0, TemplateItem);

            cboTemplate.DataSource = TemplateList;
            cboTemplate.ValueMember = "Value";
            cboTemplate.DisplayMember = "Name";

            //Set Values
            if (ApplicationFow.CurrentConect != null)
            {
                cboProvider.SelectedValue = (string)Enum.GetName(typeof(EnumProviders), ApplicationFow.CurrentConect.Provider); 
            }

        }

        private void btnMetadata_Click(object sender, EventArgs e)
        {
            LogicDataAccessGetter bl = new LogicDataAccessGetter();
            procedure = bl.MetaDataFromStoreProcedure(txtPackage.Text, txtObject.Text, null, EnumProviders.Oracle, null);
            gvwParametros.DataSource = procedure.Parameters;
            gvwResult.DataSource = procedure.ResultColumns;
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            frmResultCode winCode = new frmResultCode();
            winCode.SetText(GetCode());
            winCode.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            rtbCode.Text = GetCode();
            tabControl1.SelectedIndex = 2;
        }

        private string GetCode()
        {
            string PathXML = Path.Combine(Environment.CurrentDirectory, @"Mapper\Temporary\Entity.xml");
            string PathXSLT = Path.Combine(Environment.CurrentDirectory, @"Mapper\Temporary\SectionCodeStoreProcedure.xslt"); 

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(procedure.GetType());
            System.IO.StreamWriter file = new System.IO.StreamWriter(PathXML);
            x.Serialize(file, procedure);
            file.Close();

            // Load the style sheet.
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(PathXSLT);

            XsltArgumentList Args = new XsltArgumentList();
            Args.AddParam("StoreProcedureName", string.Empty, txtObject.Text);
            Args.AddParam("EntityCollectionName", string.Empty, "List<EntityName>");
            Args.AddParam("EntityName", string.Empty, "EntityName");
            Args.AddParam("Languaje", string.Empty, cboLanguaje.SelectedValue);
            Args.AddParam("Provider", string.Empty, cboProvider.SelectedValue);
            Args.AddParam("ExecuteType", string.Empty, lbxExecute.Text);
            Args.AddExtensionObject("http://schemas.microsoft.com/ado/2006/04/codegeneration", new UtilProvider());

            // Transform the file and output an HTML string.
            string HTMLoutput;
            StringWriter writer = new StringWriter();
            xslt.Transform(PathXML, Args, writer);
            HTMLoutput = writer.ToString();
            writer.Close();
            return HTMLoutput;

        }

       
      
    }
}
