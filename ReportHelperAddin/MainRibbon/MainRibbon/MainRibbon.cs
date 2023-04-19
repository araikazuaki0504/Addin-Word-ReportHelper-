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

namespace MainRibbon
{
    public partial class ReportHelper
    {

        private void ViewerForTextBooks_Click(object sender, RibbonControlEventArgs e)
        {
            Form form = new SelectingTextBook();
            form.ShowDialog();
        }

        private void ViewerFromDialog_Click(object sender, RibbonControlEventArgs e)
        {
            SelectingFile.ShowDialog();
            SwitchFormByExtention(SelectingFile.FileName);
        }

        private void SwitchFormByExtention(string filePath)
        {
            string Extention = filePath.Split('.').Last();
            Form ViewForm = null;

            switch(Extention)
            {
                case "_":
                    MessageBox.Show("このファイルは対応していません");
                    break;
                case "pdf":
                    ViewForm = new TextViewer(filePath);
                    break;
                case "png":
                case "jpg":
                case "bmp":
                case "gif":
                case "tiff":
                    ViewForm = new TextViewerFromDialog(filePath);
                    break;
            }

            ViewForm.ShowDialog();
        }
    }
}
