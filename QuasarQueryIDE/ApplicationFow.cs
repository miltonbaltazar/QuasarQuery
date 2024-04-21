using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using WeifenLuo.WinFormsUI;
using QuasarQuery.Core;
using QuasarQuery.Entity;
using QuasarQuery.Entity.Collection;
using QuasarQuery.Logic;
using WeifenLuo.WinFormsUI.Docking;
using QuasarQuery.Common;
using System.Configuration;
using System.IO;
using System.Linq;

namespace QuasarQuery.IDE
{
    public class ApplicationFow: ApplicationContext
    {
        private static WinQuasarQueryUI instance = new WinQuasarQueryUI();
        private static Session currentConect;
        private static SessionCollection conectCollection = new SessionCollection();
        private static FrmResult WinResult;
        private static FrmDocument currentDocument;
        private static FrmExplorer explorer;
        private static Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private static string currentId;
        private static FrmCompareDataBase compareBd;

        public ApplicationFow()
        {
           this.MainForm = instance;
           WinResult = new FrmResult();
           WinResult.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide;
           instance.Show();
        }

        public static void ConfigSetAtribute(string Atrr, string value)
        {
            Config.AppSettings.Settings[Atrr].Value = value;
        }

        public static void ConfigSave(ConfigurationSaveMode SaveType)
        {
            Config.Save(SaveType);
        }


        public static string ConfigGetAtribute(string Atr)
        {
                return ConfigurationManager.AppSettings[Atr];
        }

        public static Session CurrentConect
        {
            get
            {
                if (currentConect == null)
                    return conectCollection.Find(value => value.Id == currentId);
                else return currentConect;
            }
        }

        public static FrmResult Result
        {
            get{return WinResult;}
            set{WinResult = value;}
        }

        public static string CurrentId
        {
            get { return currentId; }
            set { currentId = value; }
        }

        public static void AddOrMergeConnect(Session ObjCon)
        {
            if (conectCollection == null)
            {
                conectCollection = new SessionCollection();
            }

            Session sesTmp = conectCollection.Where(c => c.Id.Equals(ObjCon.Id, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            if(sesTmp != null)
            {
                int sesIdx = conectCollection.IndexOf(sesTmp);
                if (sesIdx >= 0)
                    conectCollection[sesIdx] = ObjCon;
            }
            else
            {
                conectCollection.Add(ObjCon);
            }
            currentId = ObjCon.Id;
            currentConect = ObjCon;
            SessionGetter.Serialize(conectCollection);
        }

        public static SessionCollection GetSessions()
        {
            conectCollection = SessionGetter.Deserialize();
            return conectCollection;
        }

        public static Session GetSession(string name)
        {
            return SessionGetter.Deserialize().Where(c => c.Id == name).FirstOrDefault(); 
        }

        public static void RemoveSession(string name)
        {
            conectCollection = SessionGetter.Deserialize();
            conectCollection.RemoveAll(c => c.Id == name);
            SessionGetter.Serialize(conectCollection);
        }

        public static void OpenChildren(DockContent document)
        {
            document.ShowHint = DockState.Document;
            document.Show(instance.dockPanel1);
        }

        public static void OpenDocument()
        {
            FrmDocument document = new FrmDocument();
            document.ShowHint = DockState.Document;
            document.Show(instance.dockPanel1);
        }

        public static void OpenCompareBd()
        {
            if (compareBd == null)
            {
                compareBd = new FrmCompareDataBase();
            }

            compareBd.ShowHint = DockState.Document;
            compareBd.Show(instance.dockPanel1);
        }

        public static void OpenExplorer()
        {
            if (explorer == null)
            {
                explorer = new FrmExplorer(); 
            }
            explorer.ShowHint = DockState.DockLeft;
            explorer.Show(instance.dockPanel1);
        }

        public static void ShowUserObjects()
        {
            explorer.ViewSchema();
        }

        public static FrmDocument CurrentDocument
        {
            get
            {
                return currentDocument;
            }
            set
            {
                currentDocument = value;
            }
        }

        public static void ShowMessage(ValidateResult result)
        {
            MessageBox.Show(result.Message);
        }

        public static void ShowResult()
        {
            DataTypeCollection paramCollection = new DataTypeCollection();
            DataType param = null;

            char []separador = {';',' ',',',')'};
            char ParamImput = ':';

            string[] query = CurrentDocument.GetQuerySelect();
            Int32 CountCharacters;
            char Caracter;

            foreach (string line in query)
            {
                CountCharacters = line.Length -1;
                for (Int32 Indexchar = 0; Indexchar <= CountCharacters; Indexchar++)
                {
                    if(line[Indexchar] == ParamImput)
                    {
                        Int32 Index = line.IndexOfAny(separador, Indexchar);

                            if (Index > 0)
                            {
                                param = new DataType();
                                param.Name = line.Substring(Indexchar, Index);
                                paramCollection.Add(param);
                            }
                    }
                } 
            }

            if (paramCollection.Count > 0)
            {
                using (FrmParametersCollection frmcll = new FrmParametersCollection())
                {
                    frmcll.ShowDialog();
                }
            }


                LGDataAccess lg = new LGDataAccess();
                WinResult.SetDataSource(lg.ExecuteQuery( ApplicationFow.CurrentConect, Util.ConvertStringArrayToString(query), paramCollection));
                WinResult.Show(instance.dockPanel1, DockState.DockBottom);

            //Int32 lastParamIndex = query.LastIndexOf(":");
            //Int32 IndexParam = 0;

            //DataTypeCollection  paramCollection = new DataTypeCollection();
            //DataType param = null;

            //        while (IndexParam <= lastParamIndex)
            //        {
            //            param = new DataType();
            //            if (query.IndexOf(":",IndexParam) > 0)
            //            {
            //                paramCollection.Add(param);
            //            }
            //                IndexParam++;
            //        }

            //        if (paramCollection != null)
            //        {
            //            using(FrmParametersCollection frmcll = new FrmParametersCollection())
            //            {
            //                frmcll.ShowDialog();
            //            }
            //        }

            //        using (LGDataAccess lg = new LGDataAccess())
            //        {
            //            WinResult.SetDataSource(lg.ExecuteQuery(CurrentDocument.GetQuerySelect()));
            //            WinResult.Show(instance.dockPanel1, DockState.DockBottom); 
            //        }

        }

     
    }
}
