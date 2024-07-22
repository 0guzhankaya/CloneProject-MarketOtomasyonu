namespace MarketOtomasyonu
{
    partial class EmployeePanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePanelForm));
            this.buttonMeat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonMilk = new System.Windows.Forms.Button();
            this.buttonBean = new System.Windows.Forms.Button();
            this.buttonFruit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonMeat
            // 
            this.buttonMeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMeat.ImageKey = "cut-of-meat.ico";
            this.buttonMeat.ImageList = this.ımageList1;
            this.buttonMeat.Location = new System.Drawing.Point(80, 82);
            this.buttonMeat.Name = "buttonMeat";
            this.buttonMeat.Size = new System.Drawing.Size(200, 200);
            this.buttonMeat.TabIndex = 0;
            this.buttonMeat.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Agriculture-Fruits-Vegetables.ico");
            this.ımageList1.Images.SetKeyName(1, "cut-of-meat.ico");
            this.ımageList1.Images.SetKeyName(2, "log_in_login_signin_icon.ico");
            this.ımageList1.Images.SetKeyName(3, "Milk.ico");
            this.ımageList1.Images.SetKeyName(4, "Robinweatherall-Veggers-Green-Bean.ico");
            this.ımageList1.Images.SetKeyName(5, "exit_icon.ico");
            // 
            // buttonMilk
            // 
            this.buttonMilk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMilk.ImageKey = "Milk.ico";
            this.buttonMilk.ImageList = this.ımageList1;
            this.buttonMilk.Location = new System.Drawing.Point(314, 82);
            this.buttonMilk.Name = "buttonMilk";
            this.buttonMilk.Size = new System.Drawing.Size(200, 200);
            this.buttonMilk.TabIndex = 1;
            this.buttonMilk.UseVisualStyleBackColor = true;
            // 
            // buttonBean
            // 
            this.buttonBean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBean.ImageKey = "Robinweatherall-Veggers-Green-Bean.ico";
            this.buttonBean.ImageList = this.ımageList1;
            this.buttonBean.Location = new System.Drawing.Point(80, 320);
            this.buttonBean.Name = "buttonBean";
            this.buttonBean.Size = new System.Drawing.Size(200, 200);
            this.buttonBean.TabIndex = 2;
            this.buttonBean.UseVisualStyleBackColor = true;
            // 
            // buttonFruit
            // 
            this.buttonFruit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFruit.ImageKey = "Agriculture-Fruits-Vegetables.ico";
            this.buttonFruit.ImageList = this.ımageList1;
            this.buttonFruit.Location = new System.Drawing.Point(314, 320);
            this.buttonFruit.Name = "buttonFruit";
            this.buttonFruit.Size = new System.Drawing.Size(200, 200);
            this.buttonFruit.TabIndex = 3;
            this.buttonFruit.UseVisualStyleBackColor = true;
            this.buttonFruit.Click += new System.EventHandler(this.buttonFruit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.ImageKey = "exit_icon.ico";
            this.buttonExit.ImageList = this.ımageList1;
            this.buttonExit.Location = new System.Drawing.Point(80, 550);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 94);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(451, 18);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(0, 16);
            this.labelHour.TabIndex = 5;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(496, 17);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(0, 16);
            this.labelMinute.TabIndex = 6;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(541, 17);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(0, 16);
            this.labelSecond.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmployeePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 660);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFruit);
            this.Controls.Add(this.buttonBean);
            this.Controls.Add(this.buttonMilk);
            this.Controls.Add(this.buttonMeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeePanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePanelForm";
            this.Load += new System.EventHandler(this.EmployeePanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMeat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button buttonMilk;
        private System.Windows.Forms.Button buttonBean;
        private System.Windows.Forms.Button buttonFruit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Timer timer1;
    }
}