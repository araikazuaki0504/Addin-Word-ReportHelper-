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
            string FolderPath = Path.GetFullPath(@"../../../../Assets/TextBooks");
            SetFileNames(FolderPath);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string FolderPath = Path.GetFullPath(@"../../../../Assets/TextBooks");
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
                this.ExprimentName.Items.Add(SplitedFilePath[SplitedFilePath.Length - 1]);
            }
        }

        // P/Invokeの定義 (pinvoke.net参照)
        public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            else
                return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

        private const int GWL_HWNDPARENT = -8;

    }
}
