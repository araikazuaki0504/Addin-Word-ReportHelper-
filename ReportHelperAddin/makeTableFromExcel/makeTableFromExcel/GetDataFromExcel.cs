using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Release = System.Runtime.InteropServices;

namespace makeTableFromExcel
{
    public class GetDataFromExcel
    {
        private string _FilePath = string.Empty;
        private bool isClosed = false;
        public GetDataFromExcel(string FilePath)
        {
            _FilePath = FilePath;
        }

        public List<object[,]> Main()
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbooks excelWorkBooks = excel.Workbooks;
            Excel.Workbook　excelWorkBook = excelWorkBooks.Open(_FilePath);
            Excel.Sheets excelSheets = excelWorkBook.Sheets;
            Excel.Worksheet excelSheet = excelSheets[1] as Excel.Worksheet;
            List<string> ColRenge = new List<string>();
            List<object[,]> GottenData = new List<object[,]>();
            KeyboardHook KeyBoardHook = new KeyboardHook();


            excel.Visible = true;
            excelWorkBook.BeforeClose += IsExcelClosed_BeforeClose;
            excelSheet.BeforeRightClick += (Excel.Range Target, ref bool Cancel) =>
            {
                foreach (Excel.Range Data in excel.Selection.Areas)
                {
                    ColRenge.Add(Data.Address.ToString());
                }


                foreach (string Col in ColRenge)
                {
                    string[] IndexArray = Col.Remove(Col.IndexOf(':'), 1).TrimStart('$').Split('$');
                    object[,] tmpBuffer = excelSheet.Range[IndexArray[0] + IndexArray[1], IndexArray[2] + IndexArray[3]].Value;
                    GottenData.Add(tmpBuffer);
                }
            };

            while (!isClosed) 
            {
                Thread.Sleep(1000);
            }

            foreach (var TargetClass in new object[5] { excel, excelWorkBooks, excelWorkBook, excelSheets, excelSheet })
            {
                Release.Marshal.ReleaseComObject(TargetClass);
            }

            excelWorkBook.Close();
            excel.Quit();
            return GottenData;
        }

        private void IsExcelClosed_BeforeClose(ref bool Cancel)
        {
            isClosed = true;
            throw new NotImplementedException();
        }
    }
}
