using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;

namespace TextsViewer
{
    public partial class BrowserByGoogle : Form
    {

        private string _GoogleURL = string.Empty;
        public BrowserByGoogle(string URL)
        {
            InitializeComponent();
            _GoogleURL = URL;
        }

        private async void BrowserByGoogle_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Info: before InitializeCoreWebView2Async");

            //initialize CoreWebView2
            //await InitializeCoreWebView2Async();
            await InitializeCoreWebView2Async(this.GoogleBrowser, @"C:\temp");

            Debug.WriteLine("Info: after InitializeCoreWebView2Async");

            //navigate to URL by setting Source property
            this.GoogleBrowser.Source = new Uri(_GoogleURL);
        }

        public async Task InitializeCoreWebView2Async()
        {
            Debug.WriteLine("Info: before EnsureCoreWebView2Async");

            //wait for CoreWebView2 initialization
            await GoogleBrowser.EnsureCoreWebView2Async();

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

        private void BrowserByGoogle_Resize(object sender, EventArgs e)
        {
            this.GoogleBrowser.ClientSize = this.ClientSize;
        }
    }
}
