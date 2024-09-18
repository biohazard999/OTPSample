namespace OTPSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxQrCode = new PictureBox();
            buttonVerify = new Button();
            textBoxOtp = new TextBox();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrCode).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQrCode
            // 
            pictureBoxQrCode.Location = new Point(284, 208);
            pictureBoxQrCode.Name = "pictureBoxQrCode";
            pictureBoxQrCode.Size = new Size(350, 350);
            pictureBoxQrCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQrCode.TabIndex = 0;
            pictureBoxQrCode.TabStop = false;
            // 
            // buttonVerify
            // 
            buttonVerify.Location = new Point(876, 312);
            buttonVerify.Name = "buttonVerify";
            buttonVerify.Size = new Size(112, 34);
            buttonVerify.TabIndex = 1;
            buttonVerify.Text = "Verify";
            buttonVerify.UseVisualStyleBackColor = true;
            buttonVerify.Click += buttonVerify_Click;
            // 
            // textBoxOtp
            // 
            textBoxOtp.Location = new Point(905, 189);
            textBoxOtp.Name = "textBoxOtp";
            textBoxOtp.Size = new Size(150, 31);
            textBoxOtp.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(835, 487);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(59, 25);
            labelResult.TabIndex = 4;
            labelResult.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 855);
            Controls.Add(labelResult);
            Controls.Add(textBoxOtp);
            Controls.Add(buttonVerify);
            Controls.Add(pictureBoxQrCode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxQrCode;
        private Button buttonVerify;
        private TextBox textBoxOtp;
        private Label labelResult;
    }
}
