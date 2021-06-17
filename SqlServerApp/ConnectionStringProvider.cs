using System.Configuration;

namespace SqlServerApp
{
    class ConnectionStringProvider
    {

        public static string Provide()
        {
            bool developmentMode = bool.Parse(ConfigurationManager.AppSettings["DevelopmentMode"]);
            var defaultConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

            if (developmentMode)
            {
                return defaultConnectionString;
            }
            else
            {
                return ConnectionForm.RequestConnectionString(defaultConnectionString);
            }
        }

    }
}
