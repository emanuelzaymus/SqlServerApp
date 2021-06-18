using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SqlServerApp
{
    class MainController : IDisposable
    {
        private readonly SqlConnection _connection;

        private readonly SqlCommand _command;
        private readonly SqlDataAdapter _dataAdapter;

        public string CurrentDatabaseName => _connection.Database;

        public MainController(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();

            _command = _connection.CreateCommand();
            _dataAdapter = new SqlDataAdapter(_command);
        }

        internal IList<string> GetDatabaseNames()
        {
            _command.CommandText = "SELECT name FROM sys.databases " +
                "WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb') " +
                "AND name NOT LIKE 'AzureStorageEmulatorDb%'";

            return _command.ExecuteReader().GetAll().Select(r => (string)r["name"]).ToList();
        }

        internal void ChangeDatabase(string databaseName)
        {
            _connection.ChangeDatabase(databaseName);
        }

        internal void CreateDatabase(string databaseName)
        {
            _command.CommandText = $"CREATE DATABASE {databaseName}";
            
            _command.ExecuteNonQuery();
        }

        internal void DropDatabase(string databaseName)
        {
            ChangeDatabase("master");
            _command.CommandText = $"DROP DATABASE {databaseName}";
            
            _command.ExecuteNonQuery();
        }

        internal IList<string> GetTableNames()
        {
            _command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            return _command.ExecuteReader().GetAll().Select(r => (string)r["TABLE_NAME"]).ToList();
        }

        internal void CreateTable()
        {
            _command.CommandText = "CREATE TABLE NewTable (Id int PRIMARY KEY)";

            _command.ExecuteNonQuery();
        }

        internal void DropTable(string tableName)
        {
            _command.CommandText = $"DROP TABLE {tableName}";

            _command.ExecuteNonQuery();
        }

        internal DataSet GetTable(string tableName, string filterConditions)
        {
            var ret = new DataSet();

            _command.CommandText = $"SELECT * FROM [{tableName}] " +
                $"{(string.IsNullOrWhiteSpace(filterConditions) ? "" : "WHERE " + filterConditions)}";

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
