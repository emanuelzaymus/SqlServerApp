namespace SqlServerApp
{
    class Indexes
    {
        public const string Clustered = "CLUSTERED";
        public const string Nonclustered = "NONCLUSTERED";
        public const string UniqueClustered = "UNIQUE CLUSTERED";
        public const string UniqueNonclustered = "UNIQUE NONCLUSTERED";

        public static string[] GetValues()
        {
            return new[] { Clustered, Nonclustered, UniqueClustered, UniqueNonclustered };
        }

        public static string GetIndex(string indexDescription)
        {
            bool clustered = !indexDescription.Contains("nonclustered");
            bool unique = indexDescription.Contains("unique");

            return clustered
                ? (unique
                    ? UniqueClustered
                    : Clustered)
                : (unique
                    ? UniqueNonclustered
                    : Nonclustered);
        }
    }
}
