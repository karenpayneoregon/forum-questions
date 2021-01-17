using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_mdb
{
    public class DataOperations
    {
        public static string _connectionString = 
            $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db1.mdb")};";

        public static List<string> Read()
        {
            
            var list = new List<string>();
            
            using (var cn = new OleDbConnection() {ConnectionString = _connectionString})
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
    }
}
