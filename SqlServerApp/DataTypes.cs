namespace SqlServerApp
{
    class DataTypes
    {
        // Exact numerics
        public const string BigInt = "bigint";
        public const string Bit = "bit";
        public const string Decimal = "decimal";
        public const string Int = "int";
        public const string Money = "money";
        public const string Numeric = "numeric";
        public const string SmallInt = "smallint";
        public const string SmallMoney = "smallmoney";
        public const string TinyInt = "tinyint";

        // Approximate numerics
        public const string Float = "float";
        public const string Real = "real";

        // Date and time
        public const string Date = "date";
        public const string DateTime2 = "datetime2";
        public const string DateTime = "datetime";
        public const string DateTimeOffset = "datetimeoffset";
        public const string SmallDateTime = "smalldatetime";
        public const string Time = "time";

        // Character strings
        public const string Char = "char";
        public const string Text = "text";
        public const string VarChar = "varchar";

        // Unicode character strings
        public const string NChar = "nchar";
        public const string NText = "ntext";
        public const string NVarchar = "nvarchar";

        // Binary strings
        public const string Binary = "binary";
        public const string Image = "image";
        public const string VarBinary = "varbinary";

        public static string[] GetValues()
        {
            return new[] {
                BigInt, Bit, Decimal, Int, Money, Numeric, SmallInt, SmallMoney, TinyInt, Float, Real,
                Date, DateTime2, DateTime, DateTimeOffset, SmallDateTime, Time,
                Char, Text, VarChar, NChar, NText, NVarchar,
                Binary, Image, VarBinary
            };
        }
    }
}
