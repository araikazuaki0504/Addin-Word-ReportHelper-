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
    public partial class TextViewerFromDialog : Form
    {
        private Bitmap resizeBmp = null;
        private String FilePath = string.Empty;
        public TextViewerFromDialog(string FilePath)
        {
            InitializeComponent();
            this.FilePath = FilePath;
            ChageRationImages();
        }

        private void vScrollBarScroll(object sender, ScrollEventArgs e)
        {
            this.TextPicture.Refresh();
        }

        private void ReDraw(object sender, PaintEventArgs e)
        {
            // スクロールバー位置より元画像を切り抜いて表示
            RectangleF rectSrc = new RectangleF(
                0,
                this.vScrollBar.Value,
                this.TextPicture.Width,
                this.TextPicture.Height);
            e.Graphics.DrawImage(resizeBmp, 0, 0, rectSrc, GraphicsUnit.Pixel);
        }

        private void ResizeWindow(object sender, EventArgs e)
        {
            if (this.resizeBmp.Height >= this.ClientSize.Height)
            {
                this.TextPicture.Height = this.ClientSize.Height;
                this.vScrollBar.Height = this.ClientSize.Height;
                this.vScrollBar.Maximum = this.resizeBmp.Height - this.TextPicture.Height;
            }

            this.TextPicture.Refresh();
        }

        private void DeactiveForm(object sender, EventArgs e)
        {
            this.Focus();
            this.TopMost = true;
        }

        private void DisplayTextForm(object sender, EventArgs e)
        {
            ChageRationImages();
        }

        private void ChageRationImages()
        {
            this.TextPicture.MouseWheel += new MouseEventHandler(MouseWheelScroll);
            this.vScrollBar.MouseWheel += new MouseEventHandler(MouseWheelScroll);

            Image TextImage = Image.FromFile(FilePath);

            int resizeWidth = this.Width;
            int resizeHeight = (int)(TextImage.Height * ((double)resizeWidth / (double)TextImage.Width));

            this.resizeBmp = new Bitmap(resizeWidth, resizeHeight);
            Graphics g = Graphics.FromImage(resizeBmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(TextImage, 0, 0, resizeWidth, resizeHeight);
            g.Dispose();

            Graphics pg = Graphics.FromHwnd(TextPicture.Handle);
            pg.DrawImage(resizeBmp, new Point(0, 0));
            this.TextPicture.Image = resizeBmp;

            // PictureBoxの再描画が必要な時に呼ばれるハンドラ
            this.TextPicture.Paint += new PaintEventHandler(ReDraw);

            // 縦スクロールバーの初期位置、最小値、最大値を設定
            this.vScrollBar.Value = 0;
            this.vScrollBar.Minimum = 0;
            this.vScrollBar.Maximum = this.resizeBmp.Height - this.TextPicture.Height;

            // スクロールバーがスクロールされた際のイベントハンドラ
            this.vScrollBar.Scroll += new ScrollEventHandler(vScrollBarScroll);
        }

        private void MouseWheelScroll(object sender, MouseEventArgs e)
        {
            int dy = this.vScrollBar.Value - e.Delta;

            if (this.vScrollBar.Minimum <= dy && dy <= this.vScrollBar.Maximum)
            {
                this.vScrollBar.Value = dy;
                this.TextPicture.Refresh();
            }
            else if (this.vScrollBar.Maximum < dy)
            {
                this.vScrollBar.Value = this.vScrollBar.Maximum;
                this.TextPicture.Refresh();
            }
            else
            {
                this.vScrollBar.Value = 0;
                this.TextPicture.Refresh();
            }

        }
    }
}
