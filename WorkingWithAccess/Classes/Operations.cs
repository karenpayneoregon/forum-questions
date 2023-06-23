using System.Data;
using System.Data.OleDb;

namespace WorkingWithAccess.Classes;

public class Operations
{

    public static string ConnectionString = 
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

    public static (bool success, DataTable table) CanConnect()
    {
        DataTable categoryTable = new DataTable();
        try
        {
            
            using OleDbConnection cn = new() { ConnectionString = ConnectionString };
            using OleDbCommand cmd = new() { Connection = cn };

            cmd.CommandText = "SELECT Identifier, Category FROM  Category ORDER BY Category";


            cn.Open();

            categoryTable.Load(cmd.ExecuteReader());

            return (true,categoryTable);
        }
        catch 
        {
            return (false, categoryTable);
        }
    }

}