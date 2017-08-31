namespace QRCodeScan
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.qrCodeText = new System.Windows.Forms.TextBox();
            this.readQR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qrCodeText
            // 
            this.qrCodeText.Location = new System.Drawing.Point(12, 41);
            this.qrCodeText.Name = "qrCodeText";
            this.qrCodeText.ReadOnly = true;
            this.qrCodeText.Size = new System.Drawing.Size(360, 22);
            this.qrCodeText.TabIndex = 1;
            // 
            // readQR
            // 
            this.readQR.Location = new System.Drawing.Point(12, 12);
            this.readQR.Name = "readQR";
            this.readQR.Size = new System.Drawing.Size(75, 23);
            this.readQR.TabIndex = 2;
            this.readQR.Text = "Read";
            this.readQR.UseVisualStyleBackColor = true;
            this.readQR.Click += new System.EventHandler(this.readQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.readQR);
            this.Controls.Add(this.qrCodeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qrCodeText;
        private System.Windows.Forms.Button readQR;
    }
}

