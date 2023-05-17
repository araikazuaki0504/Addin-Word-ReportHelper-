using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using TextsViewer;
using FetchData = makeTableFromExcel.GetDataFromExcel;

namespace MainRibbon
{
    public partial class ReportHelper
    {

        private void ViewerForTextBooks_Click(object sender, RibbonControlEventArgs e)
        {
            using (Form form = new SelectingTextBook())
            {
                form.ShowDialog();
            }
        }

        private void ViewerFromDialog_Click(object sender, RibbonControlEventArgs e)
        {
            SelectingFile.ShowDialog();
            using (Form form = new OwnerForm(SelectingFile.FileName))
            {
                form.ShowDialog();
            }
        }

        private void CreateTableFromExcel_Click(object sender, RibbonControlEventArgs e)
        {
            SelectingFile.ShowDialog();
            FetchData fetchData = new FetchData(SelectingFile.FileName);
            List<object[,]> Data = fetchData.Main();
            Debug.WriteLine(Data[0][1, 1].ToString());
            
        }

        private void ToGoogling_Click(object sender, RibbonControlEventArgs e)
        {
            string GoogleURL = "https://www.google.co.jp";
            using (Form form = new OwnerForm(GoogleURL))
            {
                form.ShowDialog();
            }
        }

        //このアドインを開いているファイルのFullPath取得
        private string getMyselfPath()
        {
            Microsoft.Office.Interop.Word.Application TargetwordApplication = Globals.ThisAddIn.Application;

            if (TargetwordApplication != null && TargetwordApplication.Documents.Count > 0)
            {
                Document activeDocument = TargetwordApplication.ActiveDocument;
                string filePath = activeDocument.FullName;
                return filePath;
            }

            return null;
        }
    }
}
