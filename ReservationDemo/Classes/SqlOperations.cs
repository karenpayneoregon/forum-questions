using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationDemo.Classes
{
    public class SqlOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=Reservations;Integrated Security=True";

        /// <summary>
        /// Read seats
        /// </summary>
        /// <returns></returns>
        public static List<SeatTable> Read()
        {
            var selectStatement = "SELECT Id, [Row], Number, Available FROM dbo.SeatTable;";
            
            var list = new List<SeatTable>();

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand {Connection = cn, CommandText = selectStatement})
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new SeatTable()
                        {
                            Id = reader.GetInt32(0), 
                            Row = reader.GetString(1), 
                            Number = reader.GetInt32(2), 
                            Available = reader.GetBoolean(3)
                        });
                    }
                }
            }


            return list;
            
        }
        /// <summary>
        /// Update single seat
        /// </summary>
        /// <param name="identifier">Seat identifier</param>
        /// <param name="available">Seat is available</param>
        public static void UpdateSeat(int identifier, bool available)
        {
            var updateStatement = "UPDATE dbo.SeatTable SET Available = @Available WHERE Id = @Id;";
            
            using (var cn = new SqlConnection {ConnectionString = _connectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn, CommandText = updateStatement })
                {
                    
                    cmd.Parameters.AddWithValue("@Available", available);
                    cmd.Parameters.AddWithValue("@Id", identifier);
                    
                    cn.Open();

                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
