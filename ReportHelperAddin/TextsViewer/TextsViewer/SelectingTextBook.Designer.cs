namespace TextsViewer
{
    partial class SelectingTextBook
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
            this.plzSelect = new System.Windows.Forms.Label();
            this.ExprimentName = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plzSelect
            // 
            this.plzSelect.AutoSize = true;
            this.plzSelect.Location = new System.Drawing.Point(14, 12);
            this.plzSelect.Name = "plzSelect";
            this.plzSelect.Size = new System.Drawing.Size(132, 20);
            this.plzSelect.TabIndex = 0;
            this.plzSelect.Text = "実験を選んでください";
            // 
            // ExprimentName
            // 
            this.ExprimentName.FormattingEnabled = true;
            this.ExprimentName.Location = new System.Drawing.Point(14, 53);
            this.ExprimentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExprimentName.Name = "ExprimentName";
            this.ExprimentName.Size = new System.Drawing.Size(258, 28);
            this.ExprimentName.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(263, 92);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(86, 31);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "決定";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SelectExpriment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 139);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ExprimentName);
            this.Controls.Add(this.plzSelect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectExpriment";
            this.Load += new System.EventHandler(this.SelectExpriment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plzSelect;
        private System.Windows.Forms.ComboBox ExprimentName;
        private System.Windows.Forms.Button OkButton;

    }
}