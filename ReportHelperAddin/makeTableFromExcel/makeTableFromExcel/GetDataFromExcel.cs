using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Release = System.Runtime.InteropServices;
using System.Windows.Forms;

namespace makeTableFromExcel
{
    public class GetDataFromExcel
    {
        private string _FilePath = string.Empty;//ファイルパスをメソッド全体で共有したいのでしょうがなく
        private bool isClosed = false;//エクセルファイルが閉じているかの確認用フラグ

        /// <summary>
        /// ファイルパスを指定
        /// </summary>
        /// <param name="FilePath"></param>
        public GetDataFromExcel(string FilePath)
        {
            _FilePath = FilePath;
        }

        /// <summary>
        /// エクセルからデータを取得*データのインデックスは１からなので注意
        /// </summary>
        /// <returns></returns>
        public List<object[,]> Main()
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbooks excelWorkBooks = excel.Workbooks;
            Excel.Workbook　excelWorkBook = excelWorkBooks.Open(_FilePath);
            Excel.Sheets excelSheets = excelWorkBook.Sheets;
            Excel.Worksheet excelSheet = excelSheets[1] as Excel.Worksheet;
            List<object[,]> GottenData = new List<object[,]>();
            List<object> SelectionAddress = new List<object>();

            excel.EnableEvents = true;
            excel.Visible = true;
            excelWorkBook.BeforeClose += IsExcelClosed_BeforeClose;
            excelSheet.BeforeRightClick += (Excel.Range Target, ref bool Cancel) =>
            {
                Excel.Range Selection = excel.Selection;
                Excel.Areas areas = Selection.Areas;

                foreach(Excel.Range selectionCells in areas)
                {
                    SelectionAddress.Add(selectionCells.Address);
                }
                
                foreach (Excel.Range Address in SelectionAddress)
                {   //１インデックスから返ってくるので注意,オリジンインデックスが0!!!なんでやーーーーー
                    object[,] Data = excelSheet.Range[Address].Value;
                    GottenData.Add(Data);
                }                
            };

            while (!isClosed) 
            {

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
