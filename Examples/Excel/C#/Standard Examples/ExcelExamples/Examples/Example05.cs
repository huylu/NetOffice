﻿using System;
using System.Windows.Forms;
using System.Globalization;
using ExampleBase;
using Office = NetOffice.OfficeApi;
using Excel = NetOffice.ExcelApi;
using NetOffice.ExcelApi.Tools.Utils;

namespace ExcelExamplesCS4
{
    /// <summary>
    /// Example 5 - Working with Charts
    /// </summary>
    class Example05 : IExample
    {
        #region IExample Member

        public void RunExample()
        {      
            // start excel and turn off msg boxes
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.DisplayAlerts = false;

            // create a utils instance, not need for but helpful to keep the lines of code low
            CommonUtils utils = new CommonUtils(excelApplication);

            // add a new workbook
            Excel.Workbook workBook = excelApplication.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets[1];

            // we need some data to display
            Excel.Range dataRange = PutSampleData(workSheet);

            // create a nice diagram
            Excel.ChartObject chart = ((Excel.ChartObjects)workSheet.ChartObjects()).Add(70, 100, 375, 225);
            chart.Chart.SetSourceData(dataRange);

            // save the book 
            string workbookFile = utils.File.Combine(HostApplication.RootDirectory, "Example05", Excel.Tools.DocumentFormat.Normal);
            workBook.SaveAs(workbookFile);

            // close excel and dispose reference
            excelApplication.Quit();
            excelApplication.Dispose();

            // show dialog for the user(you!)
            HostApplication.ShowFinishDialog(null, workbookFile);
        }

        public void Connect(IHost hostApplication)
        {
            HostApplication = hostApplication;
        }

        public string Caption
        {
            get { return HostApplication.LCID == 1033 ? "Example05" : "Beispiel05"; }
        }

        public string Description
        {
            get { return HostApplication.LCID == 1033 ? "Working with Charts" : "Arbeiten mit Charts"; }
        }

        public UserControl Panel
        {
            get { return null; }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Current Example Host
        /// </summary>
        internal IHost HostApplication { get; private set; }

        #endregion

        #region Helper

        private static Excel.Range PutSampleData(Excel.Worksheet workSheet)
        {
            workSheet.Cells[2, 2].Value = "Date";
            workSheet.Cells[3, 2].Value = DateTime.Now.ToShortDateString();
            workSheet.Cells[4, 2].Value = DateTime.Now.ToShortDateString();
            workSheet.Cells[5, 2].Value = DateTime.Now.ToShortDateString();
            workSheet.Cells[6, 2].Value = DateTime.Now.ToShortDateString();

            workSheet.Cells[2, 3].Value = "Columns1";
            workSheet.Cells[3, 3].Value = 25;
            workSheet.Cells[4, 3].Value = 33;
            workSheet.Cells[5, 3].Value = 30;
            workSheet.Cells[6, 3].Value = 22;

            workSheet.Cells[2, 4].Value = "Column2";
            workSheet.Cells[3, 4].Value = 25;
            workSheet.Cells[4, 4].Value = 33;
            workSheet.Cells[5, 4].Value = 30;
            workSheet.Cells[6, 4].Value = 22;

            workSheet.Cells[2, 5].Value = "Column3";
            workSheet.Cells[3, 5].Value = 25;
            workSheet.Cells[4, 5].Value = 33;
            workSheet.Cells[5, 5].Value = 30;
            workSheet.Cells[6, 5].Value = 22;

            return workSheet.Range("$B2:$E6");
        }

        #endregion
    }
}
