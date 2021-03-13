using System;
using System.Data.SqlClient;

namespace WorkingWithSqlServer.Classes
{
    public class DataOperations1
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;" +
            "Initial Catalog=NorthWind2020;" +
            "Integrated Security=True";

        public static (bool success, Exception exception, int? id) AddToDatabase(int barCodeIdentifier, int customerIdentifier, int quantity, string name)
        {
            var insertStatement =
                "INSERT INTO Sales(barcode_id,customer_id, pos_id,qty) " +
                "VALUES (@barcode_id,@customer_id) ";


            using var cn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = insertStatement };

            cmd.Parameters.AddWithValue("@barcode_id", barCodeIdentifier);
            cmd.Parameters.AddWithValue("@customer_id", customerIdentifier);
            cmd.Parameters.AddWithValue("@qty", quantity);

            var trans = cn.BeginTransaction("Ops1");
            
            try
            {
                cn.Open();
                
                cmd.ExecuteNonQuery();
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.CommandText = "Select id From POS Where Name=@name";
                
                cmd.ExecuteReader();
                
                var identifier = Convert.ToInt32(cmd.ExecuteScalar());
                
                return (true, null, identifier);
            }
            catch (Exception e)
            {
                try
                {
                    trans.Rollback();
                }
                catch (Exception transEx)
                {
                    return (false, transEx, null);
                }
                return (true, e, null);
            }

        }
    }
}
