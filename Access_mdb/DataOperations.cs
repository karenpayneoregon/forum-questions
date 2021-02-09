using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_mdb
{
    public class DataOperations
    {
        public static string ConnectionString = 
            "Provider=Microsoft.Jet.OLEDB.4.0;" + 
            $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db1.mdb")};";

        public static DataTable ReadTextFile()
        {
           
            var connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={AppDomain.CurrentDomain.BaseDirectory}; " + 
                                   "Extended Properties=\"text;HDR=YES;FMT=TabDelimited;\"";
            var selectStatement = "select top 10 * from " + "Data.txt";
            
            using (var cn = new OleDbConnection() {ConnectionString = connectionString })
            {
                try
                {
                    cn.Open();

                    var da = new OleDbDataAdapter(selectStatement, cn);
                    var dt = new DataTable { TableName = "Data" };
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    var dt = new DataTable();
                    dt.Columns.Add(new DataColumn() { ColumnName = "Error"});
                    dt.Rows.Add(ex.Message);
                    return dt;
                }
            }
        }

        public static List<string> Read()
        {
            
            var list = new List<string>();
            
            using (var cn = new OleDbConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new OleDbCommand() {Connection = cn})
                {
                    cmd.CommandText = "SELECT [Consonant Determiner Required] FROM DeterminersWithA;";
                    
                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }

            return list;
        }

        public static void Read1()
        {

            using (var cn = new OleDbConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new OleDbCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT [Consonant Determiner Required] FROM DeterminersWithA;";

                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }

        }
    }
}
