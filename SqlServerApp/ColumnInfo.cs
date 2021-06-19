namespace SqlServerApp
{
    class ColumnInfo
    {
        public string ColumnName { get; }

        public string DataType { get; }

        public bool IsNullable { get; }

        public bool? AutoIncrement { get; }

        public ColumnInfo(string columnName, string dataType, bool isNullable, bool? autoIncrement = null)
        {
            ColumnName = columnName;
            DataType = dataType;
            IsNullable = isNullable;
            AutoIncrement = autoIncrement;
        }
    }
}
