
namespace TextsViewer
{
    partial class TextViewer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PDFViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFViewer
            // 
            this.PDFViewer.AllowExternalDrop = true;
            this.PDFViewer.CreationProperties = null;
            this.PDFViewer.DefaultBackgroundColor = System.Drawing.Color.White;
            this.PDFViewer.Location = new System.Drawing.Point(12, 12);
            this.PDFViewer.Name = "PDFViewer";
            this.PDFViewer.Size = new System.Drawing.Size(781, 560);
            this.PDFViewer.TabIndex = 0;
            this.PDFViewer.ZoomFactor = 1D;
            // 
            // TextViewer
            // 
            this.ClientSize = new System.Drawing.Size(805, 584);
            this.Controls.Add(this.PDFViewer);
            this.Name = "TextViewer";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.TextViewer_Deactivate);
            this.Load += new System.EventHandler(this.TextViewer_Load);
            this.Resize += new System.EventHandler(this.DisplayTextBook_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 PDFViewer;
    }
}

