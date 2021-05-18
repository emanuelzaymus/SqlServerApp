using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlServerApp
{
    public static class SqlDataReaderExtensions
    {

        public static IEnumerable<SqlDataReader> GetAll(this SqlDataReader reader)
        {
            while (reader.Read())
            {
                yield return reader;
            }
            reader.Close();
        }

    }
}
