using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;

namespace TextsViewer
{
    public partial class TextViewer : Form
    {
        private string _TargetPath = string.Empty;
        public TextViewer(string SelectedFilePath)
        {
            InitializeComponent();
            _TargetPath = SelectedFilePath;
        }

        private void DisplayTextBook_Resize(object sender, EventArgs e)
        {
            this.PDFViewer.ClientSize = this.ClientSize;
        }


        private async void TextViewer_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Info: before InitializeCoreWebView2Async");

            //initialize CoreWebView2
            //await InitializeCoreWebView2Async();
            await InitializeCoreWebView2Async(PDFViewer, @"D:\Temp");

            Debug.WriteLine("Info: after InitializeCoreWebView2Async");

            //navigate to URL by setting Source property
            PDFViewer.Source = new Uri(_TargetPath, UriKind.Absolute);
        }

        public async Task InitializeCoreWebView2Async()
        {
            Debug.WriteLine("Info: before EnsureCoreWebView2Async");

            //wait for CoreWebView2 initialization
            await PDFViewer.EnsureCoreWebView2Async();

            Debug.WriteLine("Info: after EnsureCoreWebView2Async");

        }

        public async Task InitializeCoreWebView2Async(Microsoft.Web.WebView2.WinForms.WebView2 wv, string webCacheDir = "")
        {
            CoreWebView2EnvironmentOptions options = null;
            string tempWebCacheDir = string.Empty;
            CoreWebView2Environment webView2Environment = null;

            //set value
            tempWebCacheDir = webCacheDir;

            if (String.IsNullOrEmpty(tempWebCacheDir))
            {
                //get fully-qualified path to user's temp folder
                tempWebCacheDir = System.IO.Path.GetTempPath();

                tempWebCacheDir = System.IO.Path.Combine(tempWebCacheDir, System.Guid.NewGuid().ToString("N"));
            }

            //webView2Environment = await CoreWebView2Environment.CreateAsync(@"C:\Program Files (x86)\Microsoft\Edge Dev\Application\85.0.564.8", tempWebCacheDir, options);
            webView2Environment = await CoreWebView2Environment.CreateAsync(null, tempWebCacheDir, options);

            //wait for CoreWebView2 initialization
            await wv.EnsureCoreWebView2Async(webView2Environment);

            System.Diagnostics.Debug.WriteLine("Cache data folder set to: " + tempWebCacheDir);
        }

        private void WebsiteNavigate(Microsoft.Web.WebView2.WinForms.WebView2 wv, string dest)
        {
            //set value
            string tempDest = dest;

            if (wv != null && wv.CoreWebView2 != null)
            {
                if (!String.IsNullOrEmpty(dest))
                {
                    if (dest != "about:blank" &&
                        !dest.StartsWith("edge://") &&
                        !dest.StartsWith("file://") &&
                        !dest.StartsWith("http://") &&
                        !dest.StartsWith("https://"))
                    {
                        //URL must start with one of the specified strings
                        //if not, pre-pend with "http://" or "https://"
                        //set value
                        tempDest = "http://" + dest;
                    }

                    //option 1
                    wv.CoreWebView2.Navigate(tempDest);

                    //option 2
                    //wv.Source = new Uri(tempDest, UriKind.Absolute);
                }
            }
        }

        private void TextViewer_Deactivate(object sender, EventArgs e)
        {
            this.Focus();
            this.TopMost = true;
        }
    }
}
