using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace QuasarQuery.Common
{
    public class SerializationUtils
    {
        // Método para serializar un objeto a JSON
        public static string SerializeToJson<T>(T obj)
        {
            // Serializa el objeto a JSON utilizando System.Text.Json
            return JsonSerializer.Serialize(obj);
        }
        // Serializa un objeto a JSON y lo guarda en un archivo
        public static void SerializeToJsonFile<T>(T obj, string filePath)
        {
            // Serializa el objeto a JSON y guarda el resultado en el archivo especificado
            File.WriteAllText(filePath, SerializeToJson(obj));
        }
        // Método para serializar un objeto a XML
        public static string SerializeToXml<T>(T obj)
        {
            // Crea un objeto StringWriter para escribir el XML
            using (StringWriter stringWriter = new StringWriter())
            {
                // Crea un objeto XmlSerializer para el tipo T
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                // Serializa el objeto a XML y escribe en el StringWriter
                xmlSerializer.Serialize(stringWriter, obj);

                // Retorna la cadena XML
                return stringWriter.ToString();
            }
        }

        // Serializa un objeto a XML y lo guarda en un archivo
        public static void SerializeToXmlFile<T>(T obj, string filePath)
        {
            // Crea un objeto StreamWriter para escribir el XML a un archivo
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, obj);
            }
        }
        // Deserializa un objeto desde JSON en un archivo
        public static T DeserializeFromJsonFile<T>(string filePath)
        {
            // Lee el contenido del archivo y lo deserializa desde JSON
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        // Deserializa un objeto desde XML en un archivo
        public static T DeserializeFromXmlFile<T>(string filePath)
        {
            // Crea un objeto StreamReader para leer el XML desde un archivo
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(streamReader);
            }
        }
    }
}
