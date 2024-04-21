using System;
using System.IO;
using QuasarQuery.Common;
using QuasarQuery.Entity.Collection;

namespace QuasarQuery.IDE
{
    public class SessionGetter
    {

        private static string sessionPath = string.Empty;
        private static void SetConfigPath()
        {
            sessionPath = Path.Combine(Environment.CurrentDirectory, @"Mapper\Session.json");
        }

        public static SessionCollection Deserialize()
        {
            SessionCollection conectCollection = new SessionCollection();
            SetConfigPath();
            if (File.Exists(sessionPath))
            {
                conectCollection = SerializationUtils.DeserializeFromJsonFile<SessionCollection>(sessionPath);
                return conectCollection;
            }
            return conectCollection;
        }


        public static bool Serialize(SessionCollection sessions)
        {
            try
            {
                SetConfigPath();
                SerializationUtils.SerializeToJsonFile<SessionCollection>(sessions, sessionPath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
