using MarketOtomasyonu.Controllers;
using MarketOtomasyonu.Enumarations;
using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class ResetPasswordForm : Form
    {
        int code;
        bool isPasswordVisible = false;

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            // LoginTable (Model Class) == tbl_Login (Database Table)

            Controller controller = new Controller();
            List<LoginTable> loginTableList = controller.getLoginTable();

            groupBoxMailField.Enabled = false;
            groupBoxChangePassword.Enabled = false;

            foreach (LoginTable loginTable in loginTableList)
            {
                cbSecurityQuestion.Items.Add(loginTable.SecurityQuestion.ToString());
            }
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result = controller.doAuthentication(txtUsername.Text.Trim().ToLower(), cbSecurityQuestion.SelectedItem.ToString(), txtSecurityAnswer.Text.Trim().ToLower());

            if (result == LoginStatus.SUCCESS)
            {
                groupBoxMailField.Enabled = true;
            }
            else if (result == LoginStatus.UNSUCCESS)
            {
                MessageBox.Show("Girilen Bilgiler Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Eksik!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Email Gönder.
        private void buttonSendCode_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emailAddress = controller.checkEmailAddress(txtUsername.Text);

            if (emailAddress == txtEmail.Text)
            {
                try
                {
                    Random random = new Random();
                    code = random.Next(111111, 999999);

                    MailAddress mailRecipient = new MailAddress(txtEmail.Text.Trim().ToLower(), txtUsername.Text);
                    MailAddress mailSender = new MailAddress("marketotomasyonadmn123@hotmail.com", "Admin");

                    MailMessage message = new MailMessage();
                    message.To.Add(mailRecipient);
                    message.From = mailSender;
                    message.Subject = "Yeni Şifre Oluşturma";
                    message.Body = "Şifrenizi değiştirmek için doğrulama kodunuz : " + code;

                    // Simple Mail Tranfer Protocol
                    SmtpClient smtp = new SmtpClient("smtp.office365.com", 587); // host, port
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("marketotomasyonadmn123@hotmail.com", "marketadmin1230!"); // Mail'i gönderecek olan alan adı, şifresi.
                    smtp.EnableSsl = true; // SSL
                    smtp.Send(message);

                    MessageBox.Show("Doğrulama Kodu Gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hesaba bağlı bir mail adresi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirmCode_Click(object sender, EventArgs e)
        {
            if (txtConfirmCode.Text == code.ToString())
            {
                groupBoxChangePassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama Kodu Onaylanamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if (!string.IsNullOrEmpty(txtNewPassword.Text) && !string.IsNullOrEmpty(txtNewPasswordAgain.Text))
            {
                if (txtNewPassword.Text == txtNewPasswordAgain.Text)
                {
                    LoginStatus result = controller.changePassword(txtUsername.Text, txtNewPassword.Text.Trim());

                    if (result == LoginStatus.SUCCESS)
                    {
                        MessageBox.Show("Şifre Başarıyla Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gerekli Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //TODO : Gerekli alanların rengi değişsin.
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Eşleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonShowHidePassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = isPasswordVisible;
            txtNewPasswordAgain.UseSystemPasswordChar = isPasswordVisible;

            buttonShowHidePassword.Visible = true;

            isPasswordVisible = !isPasswordVisible;
        }
    }
}
