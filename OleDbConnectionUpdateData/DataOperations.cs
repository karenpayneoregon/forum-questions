using System;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace OleDbConnectionUpdateData
{
    public class DataOperations
    {
        private static string _connectionString = "TODO";
        
        public delegate void OnFinish();
        public static event OnFinish OnFinishedEvent;
        
        public delegate void OnException(Exception sender);
        public static event OnException OnExceptionEvent;

        public static async Task<bool> PerformUpdateTask()
        {

            return await Task.Run(async () =>
            {
                using (var cn = new OleDbConnection(_connectionString))
                {

                    using (var cmd = new OleDbCommand() { Connection = cn })
                    {

                        cmd.CommandText = "TODO";

                        try
                        {
                            await cn.OpenAsync();
                            var result = await cmd.ExecuteNonQueryAsync();
                            OnFinishedEvent?.Invoke();
                            return result == 1;
                        }
                        catch (Exception ex)
                        {
                            OnExceptionEvent?.Invoke(ex);
                            return false;
                        }
                    }
                }
            
            });
        }

    }
}