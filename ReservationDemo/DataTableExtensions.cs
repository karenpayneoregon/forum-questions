using System.Data;
using System.Linq;

namespace CommonExtensions
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// Determine if the DataTable has duplications based on a column
        /// where the column may be a concatenation of two or more columns
        /// </summary>
        /// <param name="sender">DataTable to check for duplicates</param>
        /// <param name="columnName">Column name to check, if column does not exists a runtime exception is thrown</param>
        /// <param name="identifier">Value in columnName</param>
        /// <returns></returns>
        public static bool HasDuplicates(this DataTable sender, string columnName, string identifier) => 
            sender.AsEnumerable()
                .Where(row => row.Field<string>(columnName) == identifier)
                .GroupBy(row => row[0]).Any(gr => gr.Count() > 1);

    }
}
