using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using QuasarQuery.Common;
using System.IO;
 

namespace QuasarQuery.Core
{
    public class Base
    {
        private static XmlDocument XmlConfig = new XmlDocument();

        private static void OpenConfig()
        {
            XmlConfig.Load(Path.Combine(Environment.CurrentDirectory, @"Mapper\QuasarQuery.xml"));
        }


        public static SolutionExplorerFolderCollection SolutionFolders()
        {
            OpenConfig();
            XmlNodeList node = XmlConfig.GetElementsByTagName(Constantes.XML_NODE_TAG_FOLDER);
            SolutionExplorerFolderCollection list = new SolutionExplorerFolderCollection();
            SolutionExplorerFolder languaje;
            foreach (XmlNode atrr in node)
            {
                languaje = new SolutionExplorerFolder();
                languaje.Name = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_NAME].Value;
                languaje.Value = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_NAME].Value;
                list.Add(languaje);
            }
            return list;
        }

        public static LanguajeCollection Languajes()
        {
            OpenConfig();
            XmlNodeList node = XmlConfig.GetElementsByTagName(Constantes.XML_NODE_TAG_LANGUAJES);
            LanguajeCollection list = new LanguajeCollection();
            Languaje languaje;
            foreach (XmlNode atrr in node[0].ChildNodes)
            {
                languaje = new Languaje();
                languaje.Name = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_NAME].Value;
                languaje.Value = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_VALUE].Value;
                list.Add(languaje);
            }
            return list;
        }
      
        public static DataTypeCollection DataTypes(string keyProvider)
        {
                OpenConfig();
                XmlNodeList node = XmlConfig.GetElementsByTagName("Provider");
                DataTypeCollection list = new DataTypeCollection();
                
                DataType type;
                foreach (XmlNode atrr in node)
                {
                    if (atrr.Name == "Provider")
                    {
                        if (atrr.Attributes["name"].Value == keyProvider)
                        {
                            XmlNodeList node1 = atrr.ChildNodes;
                            foreach(XmlNode node2 in node1)
                            {
                                if (node2.Name == "DataTypes")
                                {
                                    XmlNodeList atrr2 = node2.ChildNodes;
                                    foreach (XmlNode item in atrr2)
                                    {
                                        type = new DataType();
                                        type.Name = item.Attributes["value"].Value;
                                        list.Add(type);
                                    }
                                }
                            }
                            
                        }
                    }
                } 
                return list;
        }
    }
}
