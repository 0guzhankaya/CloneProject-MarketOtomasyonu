namespace MarketOtomasyonu
{
    partial class ResetPasswordForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.groupBoxSecurityQuestion = new System.Windows.Forms.GroupBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxChangePassword = new System.Windows.Forms.GroupBox();
            this.buttonShowHidePassword = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.groupBoxMailField = new System.Windows.Forms.GroupBox();
            this.buttonConfirmCode = new System.Windows.Forms.Button();
            this.txtConfirmCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxSecurityQuestion.SuspendLayout();
            this.groupBoxChangePassword.SuspendLayout();
            this.groupBoxMailField.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSecurityQuestion
            // 
            this.groupBoxSecurityQuestion.Controls.Add(this.buttonRequest);
            this.groupBoxSecurityQuestion.Controls.Add(this.cbSecurityQuestion);
            this.groupBoxSecurityQuestion.Controls.Add(this.txtSecurityAnswer);
            this.groupBoxSecurityQuestion.Controls.Add(this.label3);
            this.groupBoxSecurityQuestion.Controls.Add(this.label2);
            this.groupBoxSecurityQuestion.Controls.Add(this.txtUsername);
            this.groupBoxSecurityQuestion.Controls.Add(this.label1);
            this.groupBoxSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSecurityQuestion.Location = new System.Drawing.Point(47, 12);
            this.groupBoxSecurityQuestion.Name = "groupBoxSecurityQuestion";
            this.groupBoxSecurityQuestion.Size = new System.Drawing.Size(404, 243);
            this.groupBoxSecurityQuestion.TabIndex = 0;
            this.groupBoxSecurityQuestion.TabStop = false;
            this.groupBoxSecurityQuestion.Text = "Güvenlik Sorusu";
            // 
            // buttonRequest
            // 
            this.buttonRequest.ForeColor = System.Drawing.Color.Navy;
            this.buttonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequest.ImageKey = "aims_gesture_hand_palm_request_icon.ico";
            this.buttonRequest.ImageList = this.ımageList1;
            this.buttonRequest.Location = new System.Drawing.Point(215, 181);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(161, 47);
            this.buttonRequest.TabIndex = 3;
            this.buttonRequest.Text = "Sorgula";
            this.buttonRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "aims_gesture_hand_palm_request_icon.ico");
            this.ımageList1.Images.SetKeyName(1, "eye_close_fill_icon.ico");
            this.ımageList1.Images.SetKeyName(2, "eye_icon.ico");
            this.ımageList1.Images.SetKeyName(3, "password_account_security_reset_safety_icon.ico");
            this.ımageList1.Images.SetKeyName(4, "Iconsmind-Outline-Mail-Send.ico");
            // 
            // cbSecurityQuestion
            // 
            this.cbSecurityQuestion.FormattingEnabled = true;
            this.cbSecurityQuestion.Location = new System.Drawing.Point(163, 88);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.Size = new System.Drawing.Size(213, 24);
            this.cbSecurityQuestion.TabIndex = 1;
            this.cbSecurityQuestion.Tag = "required";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(164, 127);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(212, 22);
            this.txtSecurityAnswer.TabIndex = 2;
            this.txtSecurityAnswer.Tag = "required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(163, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "required";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // groupBoxChangePassword
            // 
            this.groupBoxChangePassword.Controls.Add(this.buttonShowHidePassword);
            this.groupBoxChangePassword.Controls.Add(this.label9);
            this.groupBoxChangePassword.Controls.Add(this.buttonChangePassword);
            this.groupBoxChangePassword.Controls.Add(this.label5);
            this.groupBoxChangePassword.Controls.Add(this.label4);
            this.groupBoxChangePassword.Controls.Add(this.txtNewPasswordAgain);
            this.groupBoxChangePassword.Controls.Add(this.txtNewPassword);
            this.groupBoxChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxChangePassword.Location = new System.Drawing.Point(47, 498);
            this.groupBoxChangePassword.Name = "groupBoxChangePassword";
            this.groupBoxChangePassword.Size = new System.Drawing.Size(404, 207);
            this.groupBoxChangePassword.TabIndex = 3;
            this.groupBoxChangePassword.TabStop = false;
            this.groupBoxChangePassword.Text = "Şifre Değiştir";
            // 
            // buttonShowHidePassword
            // 
            this.buttonShowHidePassword.ImageKey = "eye_icon.ico";
            this.buttonShowHidePassword.ImageList = this.ımageList1;
            this.buttonShowHidePassword.Location = new System.Drawing.Point(327, 55);
            this.buttonShowHidePassword.Name = "buttonShowHidePassword";
            this.buttonShowHidePassword.Size = new System.Drawing.Size(42, 44);
            this.buttonShowHidePassword.TabIndex = 5;
            this.buttonShowHidePassword.UseVisualStyleBackColor = true;
            this.buttonShowHidePassword.Click += new System.EventHandler(this.buttonShowHidePassword_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.ImageKey = "password_account_security_reset_safety_icon.ico";
            this.buttonChangePassword.ImageList = this.ımageList1;
            this.buttonChangePassword.Location = new System.Drawing.Point(175, 134);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(161, 43);
            this.buttonChangePassword.TabIndex = 2;
            this.buttonChangePassword.Text = "Şifreyi Yenile";
            this.buttonChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tekrar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yeni Şifre :";
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(116, 85);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(192, 22);
            this.txtNewPasswordAgain.TabIndex = 1;
            this.txtNewPasswordAgain.Tag = "required1";
            this.txtNewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(116, 39);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(192, 22);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.Tag = "required1";
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // groupBoxMailField
            // 
            this.groupBoxMailField.Controls.Add(this.buttonConfirmCode);
            this.groupBoxMailField.Controls.Add(this.txtConfirmCode);
            this.groupBoxMailField.Controls.Add(this.label7);
            this.groupBoxMailField.Controls.Add(this.buttonSendCode);
            this.groupBoxMailField.Controls.Add(this.txtEmail);
            this.groupBoxMailField.Controls.Add(this.label6);
            this.groupBoxMailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMailField.Location = new System.Drawing.Point(47, 273);
            this.groupBoxMailField.Name = "groupBoxMailField";
            this.groupBoxMailField.Size = new System.Drawing.Size(404, 201);
            this.groupBoxMailField.TabIndex = 1;
            this.groupBoxMailField.TabStop = false;
            this.groupBoxMailField.Text = "Mail Alanı";
            // 
            // buttonConfirmCode
            // 
            this.buttonConfirmCode.BackColor = System.Drawing.Color.LightGreen;
            this.buttonConfirmCode.ImageKey = "Iconsmind-Outline-Mail-Send.ico";
            this.buttonConfirmCode.ImageList = this.ımageList1;
            this.buttonConfirmCode.Location = new System.Drawing.Point(305, 133);
            this.buttonConfirmCode.Name = "buttonConfirmCode";
            this.buttonConfirmCode.Size = new System.Drawing.Size(64, 37);
            this.buttonConfirmCode.TabIndex = 3;
            this.buttonConfirmCode.UseVisualStyleBackColor = false;
            this.buttonConfirmCode.Click += new System.EventHandler(this.buttonConfirmCode_Click);
            // 
            // txtConfirmCode
            // 
            this.txtConfirmCode.Location = new System.Drawing.Point(161, 140);
            this.txtConfirmCode.Name = "txtConfirmCode";
            this.txtConfirmCode.Size = new System.Drawing.Size(134, 22);
            this.txtConfirmCode.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Doğrulama Kodu : ";
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Location = new System.Drawing.Point(199, 78);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(170, 37);
            this.buttonSendCode.TabIndex = 1;
            this.buttonSendCode.Text = "Doğrulama Kodu Gönder";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adresi :";
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 723);
            this.Controls.Add(this.groupBoxMailField);
            this.Controls.Add(this.groupBoxChangePassword);
            this.Controls.Add(this.groupBoxSecurityQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Otomasyonu - Şifre Sıfırla";
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.groupBoxSecurityQuestion.ResumeLayout(false);
            this.groupBoxSecurityQuestion.PerformLayout();
            this.groupBoxChangePassword.ResumeLayout(false);
            this.groupBoxChangePassword.PerformLayout();
            this.groupBoxMailField.ResumeLayout(false);
            this.groupBoxMailField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSecurityQuestion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbSecurityQuestion;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBoxMailField;
        private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonConfirmCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonShowHidePassword;
    }
}