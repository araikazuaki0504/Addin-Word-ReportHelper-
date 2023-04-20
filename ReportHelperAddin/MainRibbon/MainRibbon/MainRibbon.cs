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
            form.Close();
        }

        private void ViewerFromDialog_Click(object sender, RibbonControlEventArgs e)
        {
            //SelectingFile.ShowDialog();
            Form form = new OwnerForm(SelectingFile.FileName);
            form.ShowDialog();
            form.Close();
        }

    }
}
