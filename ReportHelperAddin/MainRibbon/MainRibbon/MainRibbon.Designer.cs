namespace MainRibbon
{
    partial class ReportHelper : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ReportHelper()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.display = this.Factory.CreateRibbonGroup();
            this.ToGoogling = this.Factory.CreateRibbonButton();
            this.ViewerFromDialog = this.Factory.CreateRibbonButton();
            this.ViewerForTextBooks = this.Factory.CreateRibbonButton();
            this.Excel = this.Factory.CreateRibbonGroup();
            this.CreateTableFromExcel = this.Factory.CreateRibbonButton();
            this.videoViewer = this.Factory.CreateRibbonGroup();
            this.baseballViewer = this.Factory.CreateRibbonButton();
            this.Netflix = this.Factory.CreateRibbonButton();
            this.YoutubeViewer = this.Factory.CreateRibbonButton();
            this.SelectingFile = new System.Windows.Forms.OpenFileDialog();
            this.tab1.SuspendLayout();
            this.display.SuspendLayout();
            this.Excel.SuspendLayout();
            this.videoViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.display);
            this.tab1.Groups.Add(this.Excel);
            this.tab1.Groups.Add(this.videoViewer);
            this.tab1.Label = "ReportHelper";
            this.tab1.Name = "tab1";
            // 
            // display
            // 
            this.display.Items.Add(this.ToGoogling);
            this.display.Items.Add(this.ViewerFromDialog);
            this.display.Items.Add(this.ViewerForTextBooks);
            this.display.Label = "表示";
            this.display.Name = "display";
            // 
            // ToGoogling
            // 
            this.ToGoogling.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ToGoogling.Image = global::MainRibbon.Properties.Resources.GoogleLogo;
            this.ToGoogling.Label = "Google";
            this.ToGoogling.Name = "ToGoogling";
            this.ToGoogling.ShowImage = true;
            this.ToGoogling.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToGoogling_Click);
            // 
            // ViewerFromDialog
            // 
            this.ViewerFromDialog.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ViewerFromDialog.Image = global::MainRibbon.Properties.Resources.pdf;
            this.ViewerFromDialog.Label = "表示テキストを選ぶ";
            this.ViewerFromDialog.Name = "ViewerFromDialog";
            this.ViewerFromDialog.ShowImage = true;
            this.ViewerFromDialog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ViewerFromDialog_Click);
            // 
            // ViewerForTextBooks
            // 
            this.ViewerForTextBooks.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ViewerForTextBooks.Image = global::MainRibbon.Properties.Resources.pdf;
            this.ViewerForTextBooks.Label = "実験テキストを表示";
            this.ViewerForTextBooks.Name = "ViewerForTextBooks";
            this.ViewerForTextBooks.ShowImage = true;
            this.ViewerForTextBooks.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ViewerForTextBooks_Click);
            // 
            // Excel
            // 
            this.Excel.Items.Add(this.CreateTableFromExcel);
            this.Excel.Label = "エクセル関係";
            this.Excel.Name = "Excel";
            // 
            // CreateTableFromExcel
            // 
            this.CreateTableFromExcel.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.CreateTableFromExcel.Image = global::MainRibbon.Properties.Resources.Excel;
            this.CreateTableFromExcel.Label = "エクセルからテーブル";
            this.CreateTableFromExcel.Name = "CreateTableFromExcel";
            this.CreateTableFromExcel.ShowImage = true;
            this.CreateTableFromExcel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateTableFromExcel_Click);
            // 
            // videoViewer
            // 
            this.videoViewer.Items.Add(this.baseballViewer);
            this.videoViewer.Items.Add(this.Netflix);
            this.videoViewer.Items.Add(this.YoutubeViewer);
            this.videoViewer.Label = "動画視聴";
            this.videoViewer.Name = "videoViewer";
            // 
            // baseballViewer
            // 
            this.baseballViewer.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.baseballViewer.Image = global::MainRibbon.Properties.Resources.Baseball;
            this.baseballViewer.Label = "高校野球中継を見る";
            this.baseballViewer.Name = "baseballViewer";
            this.baseballViewer.ShowImage = true;
            this.baseballViewer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.baseballViewer_Click);
            // 
            // Netflix
            // 
            this.Netflix.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Netflix.Image = global::MainRibbon.Properties.Resources.Netflix_Symbol;
            this.Netflix.Label = "Netflix視聴";
            this.Netflix.Name = "Netflix";
            this.Netflix.ShowImage = true;
            this.Netflix.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Netflix_Click);
            // 
            // YoutubeViewer
            // 
            this.YoutubeViewer.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.YoutubeViewer.Image = global::MainRibbon.Properties.Resources.youtubeLogo;
            this.YoutubeViewer.Label = "Youtube視聴";
            this.YoutubeViewer.Name = "YoutubeViewer";
            this.YoutubeViewer.ShowImage = true;
            this.YoutubeViewer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.YoutubeViewer_Click);
            // 
            // SelectingFile
            // 
            this.SelectingFile.FileName = "SelectingFile";
            // 
            // ReportHelper
            // 
            this.Name = "ReportHelper";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.display.ResumeLayout(false);
            this.display.PerformLayout();
            this.Excel.ResumeLayout(false);
            this.Excel.PerformLayout();
            this.videoViewer.ResumeLayout(false);
            this.videoViewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup display;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ViewerForTextBooks;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ViewerFromDialog;
        private System.Windows.Forms.OpenFileDialog SelectingFile;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Excel;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateTableFromExcel;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ToGoogling;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton baseballViewer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup videoViewer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Netflix;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton YoutubeViewer;
    }

    partial class ThisRibbonCollection
    {
        internal ReportHelper Ribbon1
        {
            get { return this.GetRibbon<ReportHelper>(); }
        }
    }
}
