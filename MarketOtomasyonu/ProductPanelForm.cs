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

namespace MarketOtomasyonu
{
    public partial class ProductPanelForm : Form
    {
        Controller controller;
        public ProductPanelForm()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void ProductPanelForm_Load(object sender, EventArgs e)
        {
            getAllProducts();
            fillProductComboBox();
        }

        private void getAllProducts()
        {
            dataGridView1.DataSource = controller.getAllProducts();
        }

        private void fillProductComboBox()
        {
            //TODO : Dinamik hale getir. Veritabanından SELECT DISTINCT FROM tbl_Product 
            comboBoxProduct.Items.Add("Elma");
            comboBoxProduct.Items.Add("Muz");
            comboBoxProduct.Items.Add("Brokoli");
            comboBoxProduct.Items.Add("Üzüm");
            comboBoxProduct.Items.Add("Lahana");
            comboBoxProduct.Items.Add("Portakal");
            comboBoxProduct.Items.Add("Çilek");
            comboBoxProduct.Items.Add("Karpuz");
            comboBoxProduct.Items.Add("Patlıcan");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.Show();
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = textBoxId.Text;
            product.QRCode = textBoxQRCode.Text;
            product.Barcode = textBoxBarcode.Text;
            product.CreationDate = dateTimePickerCreationDate.Value;
            product.UpdateDate = dateTimePickerUpdateDate.Value;
            product.ProductName = comboBoxProduct.SelectedItem.ToString();
            product.Kilogram = int.Parse(textBoxKilogram.Text);
            product.Price = int.Parse(textBoxPrice.Text);
            product.Endorsement = int.Parse(textBoxEndorsement.Text);

            LoginStatus result = controller.addProduct(product);

            if (result == LoginStatus.SUCCESS)
            {
                MessageBox.Show("Ürün Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getAllProducts();
            }
            else if (result == LoginStatus.UNSUCCESS)
            {
                MessageBox.Show("Ürün Kaydedilirken Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm Gerekli Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxQRCode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxBarcode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerCreationDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
            {
                dateTimePickerUpdateDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }

            comboBoxProduct.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxKilogram.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxEndorsement.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = textBoxId.Text;
            product.QRCode = textBoxQRCode.Text;
            product.Barcode = textBoxBarcode.Text;
            product.CreationDate = dateTimePickerCreationDate.Value;
            product.UpdateDate = dateTimePickerUpdateDate.Value;
            product.ProductName = comboBoxProduct.SelectedItem.ToString();
            product.Price = int.Parse(textBoxPrice.Text);
            product.Kilogram = int.Parse(textBoxKilogram.Text);
            product.Endorsement = int.Parse(textBoxEndorsement.Text);

            LoginStatus result = controller.updateProduct(product);

            if (result == LoginStatus.SUCCESS)
            {
                MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getAllProducts();
            }
            else if (result == LoginStatus.UNSUCCESS)
            {
                MessageBox.Show("Ürün Güncellenirken Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm Gerekli Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxId.Text))
            {
                LoginStatus result = controller.deleteProduct(int.Parse(textBoxId.Text));

                if (result == LoginStatus.SUCCESS)
                {
                    MessageBox.Show("Seçilen Ürün Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.getAllProducts();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Ürün Silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silmek İstenilen Ürünü Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearFields()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedItem = 0;
                }
            }
        }
    }
}
