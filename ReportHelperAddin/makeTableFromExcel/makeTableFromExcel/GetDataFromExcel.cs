using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Excel;

namespace makeTableFromExcel
{
    public class GetDataFromExcel
    {
        private string _FilePath = string.Empty;
        public GetDataFromExcel(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Main()
        {
            Excel.Application TargetExcel;
            try
            {
                TargetExcel = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"errorMessage{ex.Message}");
                return;
            }

            Excel.Workbooks xlBooks = null;
            Excel.Workbook xlBook = null;
            Excel.Sheets xlSheets = null;
            Excel.Worksheet xlSheet = null;
            Excel.Range xlCells = null;
            Excel.Range xlCell = null;
            try
            {
                xlBooks = TargetExcel.Workbooks;
                if (xlBooks.Count >= 2)
                {
                    Console.WriteLine("Excelファイルを複数開かないでください。");
                    return;
                }
                else if (xlBooks.Count == 0)
                {
                    return;
                }

                Fetch(xlBooks, xlBook, xlSheets, xlSheet, xlCells, xlCell);
            }
            finally
            {
                // 解放処理
                foreach (object comObj in new object[] { xlCell, xlCells, xlSheet, xlSheets, xlBook, xlBooks })
                {
                    if (comObj != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(comObj);
                }
                System.Runtime.InteropServices.Marshal.ReleaseComObject(TargetExcel);
            }
        }

        private void Fetch(Excel.Workbooks xlBooks, Excel.Workbook xlBook, Excel.Sheets xlSheets, Excel.Worksheet xlSheet, Excel.Range xlCells, Excel.Range xlCell)
        {
            // 先頭のシートのA1セルに文字列を書き込みます。
            xlBook = xlBooks.Item[1];
            xlSheets = xlBook.Sheets;
            xlSheet = xlSheets.Item[1];
            xlCells = xlSheet.Cells;
            xlCell = xlCells[1, 1];
            xlCell.Value = "C#から書き込み";

        }
    }
}
