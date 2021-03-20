using System;
using System.Data;
using System.IO;
using SpreadsheetLight;

namespace SpreadSheetLight2
{
    public class ExcelOperations
    {
        private static string _excelFileName => 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExcelBookTest.xlsx");
        
        private static string _sheetName = "Sheet1";

        public static bool FileExist => File.Exists(_excelFileName);

        public static Exception Exception { get; set; }
        
        public static DataTable Read()
        {

            Exception = null;
            
            var dt = new DataTable();
            
            dt.Columns.Add("Student", typeof(string));
            dt.Columns.Add("rollno", typeof(int));
            dt.Columns.Add("Course", typeof(string));

            try
            {
                using (var doc = new SLDocument(_excelFileName, _sheetName))
                {

                    var stats = doc.GetWorksheetStatistics();


                    for (int index = 1; index < stats.EndRowIndex + 1; index++)
                    {

                        var col1Value = doc.GetCellValueAsString(index, 1);
                        var col2Value = doc.GetCellValueAsString(index, 2);
                        var col3Value = doc.GetCellValueAsString(index, 3);

                        if (int.TryParse(col2Value, out var rollNumber))
                        {
                            dt.Rows.Add(col1Value, rollNumber, col3Value);
                        }

                    }

                    
                }
            }
            catch (Exception ex)
            {
                Exception = ex;
            }

            return dt;
        }

        public static bool Write(DataTable pDataTable, bool pColumnHeaders = true)
        {

            Exception = null;
            /*
             * Copy the original DataTable so we can insert a row between
             * first row column names and actual data to match up with
             * the question asked.
             */
            var dt = pDataTable.Copy();
            var dr = dt.NewRow();
            dt.Rows.InsertAt(dr,0);

            try
            {
                using (var doc = new SLDocument(_excelFileName))
                {

                    doc.SelectWorksheet(_sheetName);
                    doc.ImportDataTable(1, SLConvert.ToColumnIndex("A"), dt, pColumnHeaders);

                    var stats = doc.GetWorksheetStatistics();

                    doc.AutoFitColumn(1, stats.EndColumnIndex);

                    doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, _sheetName);

                    doc.SaveAs(_excelFileName);

                    return true;

                }
            }
            catch (Exception ex)
            {
                Exception = ex;
                return false;
            }
        }

    }
}