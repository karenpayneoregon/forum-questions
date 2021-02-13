using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using static WorkingWithMsAccessImages.Classes.ConversionHelpers;

namespace WorkingWithMsAccessImages.Classes
{
    public class Operations
    {
        public DataTable PictureDataTable { get; set; }
        public DataTable CategoriesDataTable { get; set; }
        
        public string ConnectionString = 
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

        /// <summary>
        /// Add new record, does not populate all columns
        /// </summary>
        /// <param name="fileName">Existing image file</param>
        /// <param name="category">primary key</param>
        /// <param name="description">Image description</param>
        /// <returns></returns>
        public PictureItem AddImage(string fileName, int category, string description)
        {

            var results = new PictureItem() {Success = false};
                
            if (!File.Exists(fileName))
            {
                results.ErrorMessage = "Failed to find file";
                return results;
            }
            

            results.ImageBytes = FileImageBytes(fileName);
            
            using (var cn = new OleDbConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new OleDbCommand { Connection = cn })
                {
                    cmd.CommandText = 
                        "INSERT INTO Pictures (Category,Picture,Description,BaseName,FileExtension) " + 
                        "Values (@Category,@Picture,@Description,@BaseName,@FileExtension)";

                    cmd.Parameters.AddRange(new OleDbParameter[]
                    {
                        new OleDbParameter
                        {
                            ParameterName = "@Category",
                            DbType = DbType.Int32,
                            Value = category
                        },
                        new OleDbParameter
                        {
                            ParameterName = "@Picture",
                            OleDbType = OleDbType.Binary,
                            Value = results.ImageBytes
                        },
                        new OleDbParameter
                        {
                            ParameterName = "@Description",
                            DbType = DbType.String,
                            Value = description
                        },
                        new OleDbParameter
                        {
                            ParameterName = "@BaseName",
                            DbType = DbType.String,
                            Value = Path.GetFileNameWithoutExtension(fileName).ToLower()
                        },
                        new OleDbParameter
                        {
                            ParameterName = "@FileExtension",
                            DbType = DbType.String,
                            Value = Path.GetExtension(fileName).Replace(".", "").ToLower()
                        }
                    });

                    try
                    {
                        cn.Open();
                        var affected = cmd.ExecuteNonQuery();
                        if (affected == 1)
                        {
                            cmd.CommandText = "Select @@Identity";
                            results.Success = true;
                            results.Identifier = (int)cmd.ExecuteScalar();
                            return results;
                        }
                        else
                        {
                            return results;
                        }
                    }
                    catch (Exception ex)
                    {
                        results.ErrorMessage = ex.Message;
                        return results;
                    }
                }
            }
        }
        /// <summary>
        /// Update description for a record
        /// </summary>
        /// <param name="primaryKey">Identifier for record to update</param>
        /// <param name="description">Description of picture</param>
        /// <returns></returns>
        public PictureItem UpdateCurrentDescription(int primaryKey, string description)
        {
            var results = new PictureItem() { Success = false };
            
            using (var cn = new OleDbConnection {ConnectionString = ConnectionString})
            {
                using (var cmd = new OleDbCommand {Connection = cn})
                {
                    cmd.CommandText = 
                        "UPDATE Pictures SET Description = @Description " + 
                        "WHERE Identifier = @Identifier";

                    var descriptionParameter = new OleDbParameter
                    {
                        DbType = DbType.String,
                        ParameterName = "@Description",
                        Value = description
                    };

                    cmd.Parameters.Add(descriptionParameter);
                    
                    var identifierParameter = new OleDbParameter
                    {
                        DbType = DbType.String,
                        ParameterName = "@Identifier",
                        Value = primaryKey
                    };

                    cmd.Parameters.Add(identifierParameter);

                    try
                    {
                        cn.Open();
                        int affected = cmd.ExecuteNonQuery();
                        if (affected == 1)
                        {
                            results.Success = true;
                        }
                    }
                    catch (Exception e)
                    {
                        results.ErrorMessage = e.Message;
                        return results;
                    }

                }
            }

            return results;
        }
        /// <summary>
        /// Load two tables, category and pictures
        /// </summary>
        public void LoadImages()
        {
            using (var cn = new OleDbConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new OleDbCommand { Connection = cn })
                {
                    cmd.CommandText = "SELECT Identifier, Category FROM  Category ORDER BY Category";

                    CategoriesDataTable = new DataTable();
                    cn.Open();
                    CategoriesDataTable.Load(cmd.ExecuteReader());

                    DataRow dr = CategoriesDataTable.NewRow();
                    dr["Identifier"] = 0;
                    dr["Category"] = "ALL";
                    CategoriesDataTable.Rows.InsertAt(dr, 0);

                    cmd.CommandText = 
                        "SELECT Identifier, Category, Picture, Description, " + 
                        "BaseName,FileExtension,BaseName + '.' + FileExtension As FullFileName FROM Pictures;";

                    PictureDataTable = new DataTable();

                    PictureDataTable.Load(cmd.ExecuteReader());
                    PictureDataTable.Columns["Picture"].ColumnMapping = MappingType.Hidden;
                }
            }
        }
        /// <summary>
        /// Load single record by primary key
        /// </summary>
        /// <param name="primaryKey">Primary key of record to locate and load</param>
        /// <returns></returns>
        public Tuple<string, byte[]> LoadSingleImage(int primaryKey)
        {
            byte[] imageBytes;

            using (var cn = new OleDbConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new OleDbCommand { Connection = cn })
                {
                    cmd.CommandText = 
                        "SELECT Identifier, Category, Picture, Description," + 
                        " BaseName,FileExtension,BaseName + '.' + FileExtension As FullFileName FROM Pictures WHERE Identifier = ?";
                    
                    cmd.Parameters.AddWithValue("?", primaryKey);

                    var dt = new DataTable();
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                    imageBytes = dt.Rows[0].Field<byte[]>("Picture");
                    var fileName = dt.Rows[0].Field<string>("FullFileName");

                    return new Tuple<string, byte[]>(fileName, imageBytes);

                }
            }
        }
        /// <summary>
        /// Load two DataTable
        /// </summary>
        public Operations()
        {
            LoadImages();
        }
    }
}
