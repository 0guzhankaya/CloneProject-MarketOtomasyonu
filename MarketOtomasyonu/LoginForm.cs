using MarketOtomasyonu.Enumarations;
using MarketOtomasyonu.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketOtomasyonu.Models;

namespace MarketOtomasyonu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.login(txtUsername.Text, txtPassword.Text);

            if (result != null && result.status == LoginStatus.SUCCESS && result.Authory == "admin")
            {
                AdminPanelForm adminPanelForm = new AdminPanelForm();
                adminPanelForm.Show();
                this.Hide();


            }
            else if (result != null && result.status == LoginStatus.SUCCESS && result.Authory == "personel")
            {
                EmployeePanelForm employeePanelForm = new EmployeePanelForm();
                employeePanelForm.Show();
                this.Hide();

            }
            else if (result != null && result.status == LoginStatus.UNSUCCESS)
            {
                MessageBox.Show("Kullanıcı Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik Parametre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.Show();
            this.Hide();
        }
    }
}
