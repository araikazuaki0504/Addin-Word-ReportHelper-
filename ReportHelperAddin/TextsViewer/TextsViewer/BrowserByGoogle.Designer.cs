
namespace TextsViewer
{
    partial class BrowserByGoogle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GoogleBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.GoogleBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // GoogleBrowser
            // 
            this.GoogleBrowser.AllowExternalDrop = true;
            this.GoogleBrowser.CreationProperties = null;
            this.GoogleBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.GoogleBrowser.Location = new System.Drawing.Point(12, 12);
            this.GoogleBrowser.Name = "GoogleBrowser";
            this.GoogleBrowser.Size = new System.Drawing.Size(781, 560);
            this.GoogleBrowser.TabIndex = 0;
            this.GoogleBrowser.ZoomFactor = 1D;
            // 
            // BrowserByGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 584);
            this.Controls.Add(this.GoogleBrowser);
            this.Name = "BrowserByGoogle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BrowserByGoogle_Load);
            this.Resize += new System.EventHandler(this.BrowserByGoogle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.GoogleBrowser)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 GoogleBrowser;

    }
}