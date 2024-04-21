using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using QuasarQuery.Logic;
using QuasarQuery.Common;
using QuasarQuery.Core;


namespace QuasarQuery.IDE
{
    public partial class FrmCompareDataBase : DockContent
    {
        public FrmCompareDataBase()
        {
            InitializeComponent();
        }

        private void btnComparerBD_Click(object sender, EventArgs e)
        {         
            string[] query = new string[2];
            query[0] = "SELECT OBJECT_NAME, OBJECT_TYPE FROM USER_OBJECTS ORDER BY 2,1";
            query[1] = "SELECT OBJECT_NAME, OBJECT_TYPE FROM USER_OBJECTS ORDER BY 2,1";

            DataTable BaseTbl = null;
            DataTable NoIncluirTbl = null;
            LGDataAccess lg = new LGDataAccess();
            BaseTbl = lg.ExecuteQuery(ApplicationFow.CurrentConect, query[0]);
            NoIncluirTbl = lg.ExecuteQuery(ApplicationFow.CurrentConect, query[1]);

            IEnumerable<string> idsInA = BaseTbl.AsEnumerable().Select(row => (string)row["OBJECT_NAME"] + ";" + (string)row["OBJECT_TYPE"]);
            IEnumerable<string> idsInB = NoIncluirTbl.AsEnumerable().Select(row => (string)row["OBJECT_NAME"] + ";" + (string)row["OBJECT_TYPE"]);
            IEnumerable<string> ANotB = idsInA.Except(idsInB);

            StringBuilder StrBuildA = new StringBuilder();
            StringBuilder StrBuildB = new StringBuilder();
            StringBuilder StrBuildC = new StringBuilder();

            StrBuildA.AppendLine("NOMBRE;TIPO");
            foreach (string ent in idsInA)
                StrBuildA.AppendLine(ent);

            rtbA.Text = StrBuildA.ToString();


            StrBuildB.AppendLine("NOMBRE;TIPO");
            foreach (string ent in idsInB)
                StrBuildB.AppendLine(ent);

            rtbB.Text = StrBuildB.ToString();


            StrBuildC.AppendLine("NOMBRE;TIPO");
            foreach (string ent in ANotB)
                StrBuildC.AppendLine(ent);

            rtbC.Text = StrBuildC.ToString();

            //DataTable TableC = CompareTbl.AsEnumerable().
            //                    Where(ra => !BaseTbl.AsEnumerable().
            //                    Any(rb => rb.Field<string>("OBJECT_NAME") == ra.Field<string>("OBJECT_NAME") && rb.Field<string>("OBJECT_TYPE") == ra.Field<string>("OBJECT_TYPE"))).
            //                    CopyToDataTable();

        }

        private void FrmCompareDataBase_Load(object sender, EventArgs e)
        {
            txtBdA.Text = ApplicationFow.CurrentConect.ConnectionString;
            txtBdB.Text = ApplicationFow.CurrentConect.ConnectionString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
