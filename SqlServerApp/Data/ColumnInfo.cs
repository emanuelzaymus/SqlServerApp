using SqlServerApp.SqlServerDb;

namespace SqlServerApp.Data
{
    class ColumnInfo
    {
        public string ColumnName { get; }

        public string DataType { get; }

        public bool IsNullable { get; }

        public bool? AutoIncrement { get; }

        public string IndexName { get; private set; }

        public string IndexType { get; private set; }

        public ColumnInfo(string columnName, string dataType, bool isNullable, bool? autoIncrement = null)
        {
            ColumnName = columnName;
            DataType = dataType;
            IsNullable = isNullable;
            AutoIncrement = autoIncrement;
        }

        internal void SetIndex(string indexName, string indexDescription)
        {
            IndexName = indexName;
            IndexType = Indexes.GetIndex(indexDescription);
        }
    }
}
