namespace BaiKTSo2_31_10_2024
{
    partial class Form1
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
            this.XoaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.ListSPBox = new System.Windows.Forms.ListBox();
            this.GioHangBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextTotal = new System.Windows.Forms.TextBox();
            this.ThanhToanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(560, 343);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(178, 32);
            this.XoaButton.TabIndex = 25;
            this.XoaButton.Text = "XÓA KHỎI GIỎ HÀNG";
            this.XoaButton.UseVisualStyleBackColor = true;
            // 
            // ThemButton
            // 
            this.ThemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemButton.Location = new System.Drawing.Point(216, 343);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(223, 32);
            this.ThemButton.TabIndex = 24;
            this.ThemButton.Text = "THÊM VÀO GIỎ HÀNG";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // ListSPBox
            // 
            this.ListSPBox.FormattingEnabled = true;
            this.ListSPBox.ItemHeight = 16;
            this.ListSPBox.Location = new System.Drawing.Point(143, 6);
            this.ListSPBox.Name = "ListSPBox";
            this.ListSPBox.Size = new System.Drawing.Size(707, 292);
            this.ListSPBox.TabIndex = 32;
            // 
            // GioHangBox
            // 
            this.GioHangBox.FormattingEnabled = true;
            this.GioHangBox.ItemHeight = 16;
            this.GioHangBox.Location = new System.Drawing.Point(873, 6);
            this.GioHangBox.Name = "GioHangBox";
            this.GioHangBox.Size = new System.Drawing.Size(486, 292);
            this.GioHangBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(918, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "TỔNG TIỀN:";
            // 
            // TextTotal
            // 
            this.TextTotal.Location = new System.Drawing.Point(1008, 343);
            this.TextTotal.Name = "TextTotal";
            this.TextTotal.Size = new System.Drawing.Size(325, 22);
            this.TextTotal.TabIndex = 35;
            // 
            // ThanhToanButton
            // 
            this.ThanhToanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhToanButton.Location = new System.Drawing.Point(1025, 415);
            this.ThanhToanButton.Name = "ThanhToanButton";
            this.ThanhToanButton.Size = new System.Drawing.Size(178, 32);
            this.ThanhToanButton.TabIndex = 36;
            this.ThanhToanButton.Text = "THANH TOÁN";
            this.ThanhToanButton.UseVisualStyleBackColor = true;
            this.ThanhToanButton.Click += new System.EventHandler(this.ThanhToanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 757);
            this.Controls.Add(this.ThanhToanButton);
            this.Controls.Add(this.TextTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GioHangBox);
            this.Controls.Add(this.ListSPBox);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.ThemButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.ListBox ListSPBox;
        private System.Windows.Forms.ListBox GioHangBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextTotal;
        private System.Windows.Forms.Button ThanhToanButton;
    }
}

