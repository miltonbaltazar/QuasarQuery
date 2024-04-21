using System;
using System.IO;
using System.Xml;
using QuasarQuery.Core;
using QuasarQuery.Common;


namespace QuasarQuery.IDE
{
    public class CodeDeveloperGetter
    {
        private static XmlDocument XmlConfig = new XmlDocument();

        private static void OpenConfig()
        {
            XmlConfig.Load(GetCodeDeveloperFilePath());
        }

        public static DataBaseCollection GetDataBaseCollection()
        {
            if (!File.Exists(GetCodeDeveloperFilePath()))
            {
                throw new Exception("No existe el archivo de plantilla");
            }

            try
            {
                OpenConfig();
                XmlNodeList node = XmlConfig.GetElementsByTagName(Constantes.XML_NODE_TAG_DATABASES);
                DataBaseCollection list = new DataBaseCollection();
                DataBaseObject database;
                foreach (XmlNode atrr in node[0].ChildNodes)
                {
                    database = new DataBaseObject();
                    database.Name = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_NAME].Value;
                    database.EnumName = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_ENUM_NAME].Value;
                    database.EnumKey = (EnumProviders)Convert.ToInt32(atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_ENUM_KEY].Value);
                    database.ConnectionString = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_CONNECTION].Value;
                    list.Add(database);
                }
                return list;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }


        public static LanguajeCollection GetLanguajesCollection()
        {
            if (!File.Exists(GetCodeDeveloperFilePath()))
            {
                throw new Exception("No existe el archivo de plantilla");
            }

            try
            {
                OpenConfig();
                XmlNodeList node = XmlConfig.GetElementsByTagName(Constantes.XML_NODE_TAG_LANGUAJES);
                LanguajeCollection list = new LanguajeCollection();
                Languaje database;
                foreach (XmlNode atrr in node[0].ChildNodes)
                {
                    database = new Languaje();
                    database.Name = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_NAME].Value;
                    database.Value = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_VALUE].Value;
                    list.Add(database);
                }
                return list;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static ElementCollection GetTemplates(EnumTypeTemplate etype)
        {
            if (!File.Exists(GetCodeDeveloperFilePath()))
            {
                throw new Exception("No existe el archivo de plantilla");
            }

            try
            {
                OpenConfig();
                XmlNodeList node = XmlConfig.GetElementsByTagName(Constantes.XML_NODE_TAG_TEMPLATES);
                ElementCollection list = new ElementCollection();
                Element element;
                EnumTypeTemplate enumTypeValue = new EnumTypeTemplate();
                foreach (XmlNode atrr in node[0].ChildNodes)
                {
                    enumTypeValue = (EnumTypeTemplate)Enum.Parse(typeof(EnumTypeTemplate), atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_TYPE].Value);
                    if (etype == enumTypeValue)
                    {
                        element = new Element();
                        element.Name = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_NAME].Value;
                        //element.KeyValue = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_VALUE].Value;
                        element.EnumKey =  Convert.ToInt32(atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_ENUM_KEY].Value);
                        element.EnumName = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_ENUM_NAME].Value;
                        element.Type = atrr.Attributes[Constantes.XML_NODE_ATTRIBUTE_TYPE].Value;
                        list.Add(element);
                    }
                }
                return list;
            }
            catch (System.Exception e)
            {
                throw new Exception("Error al obtener la plantilla", e);
            }
        }

        private static string GetCodeDeveloperFilePath()
        {
            return Path.Combine(Environment.CurrentDirectory, @"Mapper\CodeDeveloper.xml");
        }
    }
}
