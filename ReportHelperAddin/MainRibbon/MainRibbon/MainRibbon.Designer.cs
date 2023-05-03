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
            this.SelectingFile = new System.Windows.Forms.OpenFileDialog();
            this.tab1.SuspendLayout();
            this.display.SuspendLayout();
            this.Excel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.display);
            this.tab1.Groups.Add(this.Excel);
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
    }

    partial class ThisRibbonCollection
    {
        internal ReportHelper Ribbon1
        {
            get { return this.GetRibbon<ReportHelper>(); }
        }
    }
}
