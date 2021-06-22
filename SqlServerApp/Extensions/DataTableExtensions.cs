using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SqlServerApp.Extensions
{
    public static class DataTableExtensions
    {
        public static List<string> GetColumnNames(this DataTable dataTable)
        {
            return dataTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
        }
    }
}
