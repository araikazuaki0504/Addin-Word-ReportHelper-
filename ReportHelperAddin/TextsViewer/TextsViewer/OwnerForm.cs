using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextsViewer
{
    public partial class OwnerForm : Form
    {
        string _Filepath = string.Empty;
        public OwnerForm(string FilePath)
        {
            InitializeComponent();
            _Filepath = FilePath;
            SwitchingByExtention(_Filepath);
        }

        public OwnerForm()
        {
            InitializeComponent();
            this.Visible = false;
            Form BrowserViewer = new BrowserByGoogle();
            this.Owner = BrowserViewer;
            BrowserViewer.Show();
        }

        private void SwitchingByExtention(string FilePath)
        {
            string Extention = FilePath.Split('.').Last();

            switch (Extention)
            {
                case "_":
                    MessageBox.Show("このファイルは対応していません");
                    break;
                case "pdf":
                    this.Visible = false;
                    Form ViewFormForPDF = new TextViewer(FilePath);
                    this.Owner = ViewFormForPDF;
                    ViewFormForPDF.Show();
                    break;
                case "png":
                case "jpg":
                case "bmp":
                case "gif":
                case "tiff":
                    this.Visible = false;
                    Form ViewFormForImages = new TextViewerFromDialog(FilePath);
                    this.Owner = ViewFormForImages;
                    ViewFormForImages.Show();
                    break;
            }

            this.Close();
        }

    }
}
