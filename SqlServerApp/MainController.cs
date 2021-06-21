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

        internal DataSet GetTableData(string tableName, string filterConditions)
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

        internal List<ColumnInfo> GetColumnInfos(string tableName)
        {
            _command.CommandText = $"SELECT column_name, data_type, is_nullable FROM information_schema.columns WHERE table_name = '{tableName}'";

            return _command.ExecuteReader().GetAll().Select(r => new ColumnInfo((string)r[0], (string)r[1], (string)r[2] == "YES")).ToList();
        }

        internal int SaveChanges(DataSet dataSet)
        {
            return _dataAdapter.Update(dataSet, dataSet.Tables[0].TableName);
        }

        internal void RenameTable(string tableName, string newTableName)
        {
            _command.CommandText = $"sp_rename '{tableName}', '{newTableName}'";

            _command.ExecuteNonQuery();
        }

        internal void AddColumn(string tableName, string columnName, string dataType, bool isNullable)
        {
            _command.CommandText = $"ALTER TABLE {tableName} ADD {columnName} {dataType} {GetNullability(isNullable)}";

            _command.ExecuteNonQuery();
        }

        internal void AlterColumn(string tableName, string columnName, string newDataType, bool newIsNullable)
        {
            _command.CommandText = $"ALTER TABLE {tableName} ALTER COLUMN {columnName} {newDataType} {GetNullability(newIsNullable)}";

            _command.ExecuteNonQuery();
        }

        internal void RenameColumn(string tableName, string columnName, string newColumnName)
        {
            _command.CommandText = $"sp_rename '{tableName}.{columnName}', '{newColumnName}', 'COLUMN'";

            _command.ExecuteNonQuery();
        }

        internal void DropColumn(string tableName, string columnName)
        {
            _command.CommandText = $"ALTER TABLE {tableName} DROP COLUMN {columnName}";

            _command.ExecuteNonQuery();
        }

        internal IEnumerable<string> GetPrimaryKey(string tableName)
        {
            _command.CommandText =
                $"SELECT c.column_name FROM information_schema.table_constraints t " +
                $"    JOIN information_schema.constraint_column_usage c " +
                $"        ON c.constraint_name = t.constraint_name " +
                $"    WHERE c.table_name = '{tableName}' " +
                $"    AND t.constraint_type = 'PRIMARY KEY'";

            return _command.ExecuteReader().GetAll().Select(r => r.GetString(0));
        }

        internal void ChangePrimaryKey(string tableName, IEnumerable<string> columns)
        {
            DropPkConstraint(tableName);

            AddPkConstraint(tableName, columns);
        }

        public void Dispose()
        {
            _dataAdapter.Dispose();
            _command.Dispose();
            _connection.Close();
        }

        private string GetNullability(bool isNullable) => isNullable ? "NULL" : "NOT NULL";

        private void AddPkConstraint(string tableName, IEnumerable<string> columns)
        {
            _command.CommandText = $"ALTER TABLE {tableName} ADD PRIMARY KEY ({string.Join(", ", columns)})";

            _command.ExecuteNonQuery();
        }

        private void DropPkConstraint(string tableName)
        {
            try
            {
                var pkConstraint = GetPkConstraint(tableName);
                _command.CommandText = $"ALTER TABLE {tableName} DROP CONSTRAINT {pkConstraint}";

                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private string GetPkConstraint(string tableName)
        {
            _command.CommandText = $"SELECT constraint_name FROM information_schema.table_constraints " +
                $"WHERE constraint_type = 'PRIMARY KEY' AND table_name = '{tableName}'";

            return _command.ExecuteReader().GetString(0);
        }

    }
}
