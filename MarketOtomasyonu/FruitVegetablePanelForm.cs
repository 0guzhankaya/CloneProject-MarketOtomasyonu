using AForge.Video.DirectShow;
using MarketOtomasyonu.Controllers;
using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    public partial class FruitVegetablePanelForm : Form
    {
        int number1, number2;
        int operation; // +, -, *, /

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public FruitVegetablePanelForm()
        {
            InitializeComponent();
        }

        private void FruitVegetablePanelForm_Load(object sender, EventArgs e)
        {
            textBoxCalculate.Text = "0";
            timer1.Start();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo camera in filterInfoCollection)
            {
                comboBoxChooseCamera.Items.Add(camera.Name);
            }
        }

        private void Numbers(object sender, MouseEventArgs e)
        {
            if (textBoxCalculate.Text == "0")
            {
                textBoxCalculate.Text = "";
            }
            textBoxCalculate.Text += ((Button)sender).Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = 1; // +
            number1 = int.Parse(textBoxCalculate.Text);
            textBoxCalculate.Text = "0";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = 2; // -
            number1 = int.Parse(textBoxCalculate.Text);
            textBoxCalculate.Text = "0";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operation = 3; // *
            number1 = int.Parse(textBoxCalculate.Text);
            textBoxCalculate.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = 4; // /
            number1 = int.Parse(textBoxCalculate.Text);
            textBoxCalculate.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxCalculate.Text = ",";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                number2 = int.Parse(textBoxCalculate.Text);
                textBoxCalculate.Text = (number1 + number2).ToString();
            }
            else if (operation == 2)
            {
                number2 = int.Parse(textBoxCalculate.Text);
                if (number1 >= number2)
                {
                    textBoxCalculate.Text = (number1 - number2).ToString();
                }
                else
                {
                    textBoxCalculate.Text = "0";
                }
            }
            else if (operation == 3)
            {
                number2 = int.Parse(textBoxCalculate.Text);
                textBoxCalculate.Text = (number1 * number2).ToString();
            }
            else if (operation == 4)
            {
                number2 = int.Parse(textBoxCalculate.Text);
                if (number2 == 0)
                {
                    textBoxCalculate.Text = "ERROR";
                }
                else
                {
                    textBoxCalculate.Text = (number1 / number2).ToString();
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxCalculate.Text = "0";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxCalculate.Text.Length != 0)
            {
                textBoxCalculate.Text = textBoxCalculate.Text.Substring(0, textBoxCalculate.Text.Length - 1);
            }
            else
            {
                textBoxCalculate.Text = "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBoxCalculate.Text.Length != 0)
            {
                textBoxCalculate.Text = textBoxCalculate.Text.Substring(0, textBoxCalculate.Text.Length - 1);
            }
            else
            {
                textBoxCalculate.Text = "0";
            }
        }

        private void buttonTurnOnCamera_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseCamera.SelectedIndex >= 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBoxChooseCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();

                timerBarcode.Start();
            }
            else
            {
                MessageBox.Show("Kamera Seçilmedi. Lütfen bir kamera seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonTurnOffCamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            pictureBoxCamera.Image = Image.FromFile("C:\\Users\\OguzhanKaya2\\source\\repos\\MarketOtomasyonu\\icons\\Camera.256.png");
            // TODO : Yolu dinamik hale getir.
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            EmployeePanelForm employeePanelForm = new EmployeePanelForm();
            employeePanelForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString();
            labelMinute.Text = DateTime.Now.Minute.ToString();
            labelSecond.Text = DateTime.Now.Second.ToString();
        }

        private void timerBarcode_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                try
                {
                    BarcodeReader reader = new BarcodeReader();
                    reader.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE, BarcodeFormat.CODE_128, BarcodeFormat.CODABAR, BarcodeFormat.CODE_39};
                    reader.Options = new ZXing.Common.DecodingOptions
                    {
                        TryHarder = true,
                        PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE, BarcodeFormat.CODE_128, BarcodeFormat.CODABAR, BarcodeFormat.CODE_39 },
                        TryInverted = true,
                        ReturnCodabarStartEnd = true
                    };
                    Result result = reader.Decode((Bitmap)pictureBoxCamera.Image); //Decode : Çözümle

                    if (result != null)
                    {
                        textBoxBarcodeCode.Text = result.ToString();
                        timerBarcode.Stop();
                    }
                    else if (result != null && result.ToString() == null)
                    {
                        // Hata durumu, barkod formatı null
                        MessageBox.Show("Barkod Okuma Hatası.\nGeçerli bir barkod bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Barkod Okuma Hatası " + e1.StackTrace , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxBarcodeCode_TextChanged(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Product tProduct = controller.getProduct(textBoxBarcodeCode.Text);
            labelProductName.Text = tProduct.ProductName.ToString();
            textBoxCalculate.Text = tProduct.Price.ToString();

            //Barkod okuma sesi
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = "barkod.wav";
            sound.Play();
        }
    }
}
