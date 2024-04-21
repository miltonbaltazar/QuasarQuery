using QuasarQuery.Entity.Enumeradores;
using QuasarQuery.Common;

namespace QuasarQuery.Entity
{
    public class Session
    {
        private EConnectResult connectResult = EConnectResult.None;
        public string Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DataSource { get; set; }
        public string Name { get; set; }
        public EnumProviders Provider { get; set; }
        public bool IntegratedSecurity { get; set; }
        public EConnectResult ConnectResult
        {
            get { return connectResult; }
            set { connectResult = value; }
        }
 
        public string Server { get; set; }
 
        public string ConnectionString
        {
            get
            {
                if (Provider == EnumProviders.SQLServer)
                    return string.Format("Server={0};Database={1};User Id ={2};Password={3};", Server, DataSource, User, Password);
                else
                    return string.Format("DATA SOURCE={0};USER ID={1};PASSWORD={2}", DataSource, User, Password);
            }
        }


        public bool IsCurrent { get; set; }

        public bool RememberPassword { get; set; }

        public string ConnectionName { get; set; }

        public bool isValid(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(Name)) message = "Ingrese el nombre de la conexión";
            if (Provider == EnumProviders.None) message = "Proveedor de datos inválido";
            if (string.IsNullOrEmpty(DataSource)) message = "Origen de datos inválido";

            bool retval;
            if (!string.IsNullOrEmpty(message))
                retval = false;
            else
                retval = true;

            return retval;
        }

    }
}
