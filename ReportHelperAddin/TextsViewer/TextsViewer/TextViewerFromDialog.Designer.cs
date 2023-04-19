namespace TextsViewer
{
    partial class TextViewerFromDialog
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
            this.TextPicture = new System.Windows.Forms.PictureBox();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.TextPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPicture
            // 
            this.TextPicture.Location = new System.Drawing.Point(0, 0);
            this.TextPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextPicture.Name = "TextPicture";
            this.TextPicture.Size = new System.Drawing.Size(913, 597);
            this.TextPicture.TabIndex = 0;
            this.TextPicture.TabStop = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(917, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 597);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarScroll);
            // 
            // DisplayTextBookForImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 600);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.TextPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DisplayTextBookForImage";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.DeactiveForm);
            this.Load += new System.EventHandler(this.DisplayTextForm);
            this.Resize += new System.EventHandler(this.ResizeWindow);
            ((System.ComponentModel.ISupportInitialize)(this.TextPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TextPicture;
        private System.Windows.Forms.VScrollBar vScrollBar;
    }
}