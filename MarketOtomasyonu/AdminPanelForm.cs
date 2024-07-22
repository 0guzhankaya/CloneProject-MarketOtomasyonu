﻿using System;
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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString();
            labelMinute.Text = DateTime.Now.Minute.ToString();
            labelSecond.Text = DateTime.Now.Second.ToString();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UserPanelForm userPanel = new UserPanelForm();
            userPanel.Show();
            this.Hide();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            ProductPanelForm productPanelForm = new ProductPanelForm();
            productPanelForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
