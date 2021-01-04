using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Channels;

namespace ItemArrayToStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new();
            
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn() {ColumnName = "Id", DataType = typeof(int), AutoIncrement = true});
            dt.Columns.Add(new DataColumn() {ColumnName = "FullName", DataType = typeof(string)});
            dt.Columns.Add(new DataColumn() {ColumnName = "BirthDate", DataType = typeof(DateTime)});

            var columnName = 
                dt.Columns
                    .Cast<DataColumn>()
                    .Select(col => col.ColumnName)
                    .ToList();

          

            dt.Rows.Add(null, "Karen Payne", new DateTime(1956,9,24));
            dt.Rows.Add(null, "Jim Beam", new DateTime(1822,3,4));
            dt.Rows.Add(new object[] { null});

            foreach (DataRow dataRow in dt.Rows)
            {
                var itemArrayData = dataRow.ItemArray.Where(item => item is not null)
                    .Select(x => x.ToString())
                    .ToArray();
                
                items.Add(new Item(itemArrayData));
            }

            items.ForEach(Console.WriteLine);
            
            Console.ReadLine();
        }
    }

    public class Item
    {
        public Item(IReadOnlyList<string> data)
        {
            Column1 = data[0];
            Column2 = data[1];
            Column3 = data[2];
        }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }

        public override string ToString() => $"{Column1},{Column2},{Column3}";

    }
    
}
