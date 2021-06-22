namespace SqlServerApp.Data
{
    public class ForeignKeyData
    {
        public string Table { get; }

        public string Column { get; }

        public string ForeignTable { get; }

        public string ForeignColumn { get; }

        public string ConstraintName { get; }

        public ForeignKeyData(string table, string column, string foreignTable, string foreignColumn, string constraintName)
        {
            Table = table;
            Column = column;
            ForeignTable = foreignTable;
            ForeignColumn = foreignColumn;
            ConstraintName = constraintName;
        }

        public override string ToString()
        {
            return $"{Column} -> {ForeignColumn} ({ForeignTable})";
        }
    }
}
