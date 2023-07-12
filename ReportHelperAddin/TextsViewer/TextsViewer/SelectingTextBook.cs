using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextsViewer
{
    public partial class SelectingTextBook : Form
    {
        public SelectingTextBook()
        {
            InitializeComponent();
        }

        private void SelectExpriment_Load(object sender, EventArgs e)
        {
            string FolderPath = Path.GetFullPath(@"C:\Addin-Word-ReportHelper-\ReportHelperAddin\Assets\よく見るやつ");
            SetFileNames(FolderPath);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string FolderPath = Path.GetFullPath(@"C:\Addin-Word-ReportHelper-\ReportHelperAddin\Assets\よく見るやつ");
            this.Visible = false;
            Form DisPlayTextBook = new TextViewer(FolderPath + "\\" + this.ExprimentName.SelectedItem.ToString());
            this.Owner = DisPlayTextBook;
            DisPlayTextBook.Show();
            
        }

        private void SetFileNames(string FolderPath)
        {
            string[] fileNames = Directory.GetFiles(FolderPath);
            this.SetFileNameToComboBox(fileNames);
        }

        private void SetFileNameToComboBox(string[] FileNames)
        {
            foreach (string FilePath in FileNames)
            {

                string[] SplitedFilePath = FilePath.Split('\\');
                if (SplitedFilePath[SplitedFilePath.Length - 1] == "このフォルダに入っているものが実験テキストを表示から選べます.txt")
                {
                    continue;
                }
                this.ExprimentName.Items.Add(SplitedFilePath[SplitedFilePath.Length - 1]);
            }
        }
    }
}
