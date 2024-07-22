using MarketOtomasyonu.Controllers;
using MarketOtomasyonu.Enumarations;
using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    public partial class UserPanelForm : Form
    {
        User user;
        Controller controller;
        public UserPanelForm()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            assignDefaultValue();
            getAllUsers();
        }

        private void assignDefaultValue()
        {
            comboBoxAuthory.Items.Add("admin");
            comboBoxAuthory.Items.Add("personel");

            comboBoxSecurityQuestion.Items.Add("En Sevdiğiniz Hayvan Nedir?"); //0
            comboBoxSecurityQuestion.Items.Add("En Sevdiğiniz Araba Markası Nedir?"); //1
            comboBoxSecurityQuestion.Items.Add("Birinci Sınıf Öğretmeninizin Adı Nedir?"); //2
            comboBoxSecurityQuestion.Items.Add("En Sevdiğiniz Hayvanın İsmi Nedir?"); //3
            comboBoxSecurityQuestion.Items.Add("Çocukluk Lakabınız Nedir?"); //4
            comboBoxSecurityQuestion.Items.Add("İlk Telefonunuzun Modeli Nedir?"); //5
        }

        private void getAllUsers()
        {
            List<User> userList = controller.getAllUsers();
            dataGridView1.DataSource = userList;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user = new User();
            user.Name = textBoxName.Text;
            user.Surname = textBoxSurname.Text;
            user.UserName = textBoxUserName.Text;
            user.Email = textBoxEmail.Text;

            if (textBoxPassword.Text.Equals(textBoxPasswordAgain))
                user.Password = textBoxPassword.Text;
            else
                MessageBox.Show("Girmiş Olduğunuz Şifreler Birbiriyle Eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            if (comboBoxAuthory.SelectedIndex <= 0) 
                MessageBox.Show("Lütfen Bir Yetki Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                user.Authory = comboBoxAuthory.SelectedItem.ToString();

            if (comboBoxSecurityQuestion.SelectedIndex <= 0)
                MessageBox.Show("Lütfen Bir Güvenlik Sorusu Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                user.SecurityQuestion = comboBoxSecurityQuestion.SelectedItem.ToString();

            user.SecurityAnswer = textBoxSecurityAnswer.Text;

            LoginStatus result = controller.addUser(user);
            if (result == LoginStatus.SUCCESS)
            {
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getAllUsers();         
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanların Hepsini Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) 
            //{

            //    textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    textBoxSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    textBoxUserName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    textBoxEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //    comboBoxAuthory.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //    comboBoxSecurityQuestion.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //    textBoxSecurityAnswer.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //}
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            user = new User();
            user.Id = int.Parse(textBoxId.Text);
            user.Name = textBoxName.Text;
            user.Surname = textBoxSurname.Text;
            user.UserName = textBoxUserName.Text;
            user.Email = textBoxEmail.Text;

            if (textBoxPassword.Text.Equals(textBoxPasswordAgain))
                user.Password = textBoxPassword.Text;
            else
                MessageBox.Show("Girmiş Olduğunuz Şifreler Birbiriyle Eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (comboBoxAuthory.SelectedIndex <= 0)
                MessageBox.Show("Lütfen Bir Yetki Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                user.Authory = comboBoxAuthory.SelectedItem.ToString();

            if (comboBoxSecurityQuestion.SelectedIndex <= 0)
                MessageBox.Show("Lütfen Bir Güvenlik Sorusu Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                user.SecurityQuestion = comboBoxSecurityQuestion.SelectedItem.ToString();

            user.SecurityAnswer = textBoxSecurityAnswer.Text;

            LoginStatus result = controller.updateUser(user);

            if (result == LoginStatus.SUCCESS)
            {
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getAllUsers();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenirken Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxId.Text))
            {
                LoginStatus result = controller.deleteUser(int.Parse(textBoxId.Text));

                if (result == LoginStatus.SUCCESS)
                {
                    MessageBox.Show("Kayıt Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.getAllUsers();
                }
                else if (result == LoginStatus.UNSUCCESS)
                {
                    MessageBox.Show("Kayıt Silinirken Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silinmek İstenilen Kaydı Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silinmek İstenilen Kaydı Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.Show();
            this.Hide();
        }
    }
}
