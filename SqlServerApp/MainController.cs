using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerApp
{
    class MainController : IDisposable
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection _connection = new SqlConnection(ConnectionString);
        private readonly SqlCommand _command;
        private readonly SqlDataAdapter _dataAdapter;

        public MainController()
        {
            _connection.Open();
            _command = _connection.CreateCommand();
            _dataAdapter = new SqlDataAdapter(_command);
        }

        internal IList<string> GetTableNames()
        {
            _command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            return _command.ExecuteReader().GetAll().Select(r => (string)r["TABLE_NAME"]).ToList();
        }

        internal DataSet GetTable(string tableName)
        {
            var ret = new DataSet();

            _command.CommandText = $"SELECT * FROM [{tableName}]";
            //var dataAdapter = new SqlDataAdapter(_command);

            _dataAdapter.Fill(ret, tableName);

            SqlCommandBuilder builder = new SqlCommandBuilder(_dataAdapter);
            _dataAdapter.InsertCommand = builder.GetInsertCommand();
            _dataAdapter.UpdateCommand = builder.GetUpdateCommand();
            _dataAdapter.DeleteCommand = builder.GetDeleteCommand();

            return ret;
        }

        internal int SaveChanges(DataSet dataSet)
        {
            return _dataAdapter.Update(dataSet, dataSet.Tables[0].TableName);
        }

        public void Dispose()
        {
            _dataAdapter.Dispose();
            _command.Dispose();
            _connection.Close();
        }
    }
}
