// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WriteOnExcel.cs" company="DanielDias, Lda">
//   Copyright (c) Daniel Dias. All rights reserved.
// </copyright>
// <summary>
// WriteOnExcel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyVideoGameCollection
{
    using System;
    using System.Runtime.InteropServices;
    using Excel = Microsoft.Office.Interop.Excel;       // microsoft Excel 14 object in references-> COM tab

    /// <summary>
    /// WriteOnExcel
    /// </summary>
    public class WriteOnExcel
    {
        public static void insertVideoGame(VideoGame videoGame)
        {
            // Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Git\MyVideoGameCollection\VideoGameCatalog.xlsx");

            for (int x = 1; x <= xlWorkbook.Sheets.Count; x++)
            {
                // More COM Objects, separated because of the for cycle
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[x];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                if (xlWorksheet.Name == videoGame.Platform)
                {
                    int rowCount = xlRange.Rows.Count;

                    xlWorksheet.Cells[rowCount, 1] = videoGame.Name;
                    xlWorksheet.Cells[rowCount, 2] = videoGame.Form;
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