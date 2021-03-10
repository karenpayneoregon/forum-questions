﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithSqlServer.Classes
{
    public class DataOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;" + 
            "Initial Catalog=NorthWind2020;" + 
            "Integrated Security=True";


        public static async Task<DataTableResults> ReadProductsTask(CancellationToken ct)
        {
            var result = new DataTableResults() { DataTable = new DataTable() };

            return await Task.Run(async () =>
            {
                await using var cn = new SqlConnection(_connectionString);
                await using var cmd = new SqlCommand() { Connection = cn };
                cmd.CommandText = SelectStatement();

                try
                {
                    await cn.OpenAsync(ct);
                }
                catch (TaskCanceledException tce)
                {
                    result.ConnectionFailed = true;
                    result.ExceptionMessage = "Connection Failed";
                    return result;
                }
                catch (Exception ex)
                {
                    result.GeneralException = ex;
                    return result;
                }

                result.DataTable.Load(await cmd.ExecuteReaderAsync(ct));

                return result;

            });

        }
        
        /// <summary>
        /// This SQL was generated in Microsoft SQL-Server Management Studio (it's free)
        /// </summary>
        /// <returns></returns>
        private static string SelectStatement()
        {
            return "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, " +
                   "C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, " +
                   "P.ReorderLevel, P.Discontinued, P.DiscontinuedDate " +
                   "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
                   "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
        }

    }

}