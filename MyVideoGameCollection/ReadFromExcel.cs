namespace MyVideoGameCollection
{
    using System;
    using System.Runtime.InteropServices;
    using Excel = Microsoft.Office.Interop.Excel;       // microsoft Excel 14 object in references-> COM tab

    public class ReadFromExcel
    {
        private VideoGameCatalog videoGameCatalog = new VideoGameCatalog();

        public static void getExcelFile()
        {
            // Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Git\MyVideoGameCollection\VideoGameCatalog.xlsx");

            for (int x = 1; x <= xlWorkbook.Sheets.Count; x++)
            {
                // More COM Objects, separated because of the for cycle
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[x];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                for (int i = 2; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (j == 1 && xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            // Add the value to the catolog
                            this.videoGameCatalog.AddVideoGameToList(new VideoGame(xlRange.Cells[i, j].Value2.ToString(), xlWorksheet.Name, xlRange.Cells[i, j + 1].Value2.ToString()));
                        }
                    }
                }

                // Release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);
            }

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            // Close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            // Quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}