namespace MarketOtomasyonu
{
    partial class FruitVegetablePanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitVegetablePanelForm));
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.ImageList(this.components);
            this.buttonFruit = new System.Windows.Forms.Button();
            this.buttonBean = new System.Windows.Forms.Button();
            this.buttonMilk = new System.Windows.Forms.Button();
            this.buttonMeat = new System.Windows.Forms.Button();
            this.groupBoxCalculator = new System.Windows.Forms.GroupBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.Calculator = new System.Windows.Forms.ImageList(this.components);
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.textBoxCalculate = new System.Windows.Forms.TextBox();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.labelEggplant = new System.Windows.Forms.Label();
            this.labelOrange = new System.Windows.Forms.Label();
            this.labelBroccali = new System.Windows.Forms.Label();
            this.labelStrawberry = new System.Windows.Forms.Label();
            this.labelCabbage = new System.Windows.Forms.Label();
            this.labelBanana = new System.Windows.Forms.Label();
            this.labelApple = new System.Windows.Forms.Label();
            this.labelMelon = new System.Windows.Forms.Label();
            this.labelGrape = new System.Windows.Forms.Label();
            this.buttonEggplant = new System.Windows.Forms.Button();
            this.FruitVegetables = new System.Windows.Forms.ImageList(this.components);
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonMelon = new System.Windows.Forms.Button();
            this.buttonStrawberry = new System.Windows.Forms.Button();
            this.buttonCabbage = new System.Windows.Forms.Button();
            this.buttonBroccali = new System.Windows.Forms.Button();
            this.buttonGrape = new System.Windows.Forms.Button();
            this.buttonBanana = new System.Windows.Forms.Button();
            this.buttonApple = new System.Windows.Forms.Button();
            this.groupBoxScan = new System.Windows.Forms.GroupBox();
            this.textBoxBarcodeCode = new System.Windows.Forms.TextBox();
            this.buttonTurnOffCamera = new System.Windows.Forms.Button();
            this.buttonTurnOnCamera = new System.Windows.Forms.Button();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChooseCamera = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerBarcode = new System.Windows.Forms.Timer(this.components);
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxCalculator.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonExit);
            this.groupBoxMenu.Controls.Add(this.buttonFruit);
            this.groupBoxMenu.Controls.Add(this.buttonBean);
            this.groupBoxMenu.Controls.Add(this.buttonMilk);
            this.groupBoxMenu.Controls.Add(this.buttonMeat);
            this.groupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMenu.Location = new System.Drawing.Point(26, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(153, 781);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Kategori";
            // 
            // buttonExit
            // 
            this.buttonExit.ImageKey = "exit_icon.ico";
            this.buttonExit.ImageList = this.Categories;
            this.buttonExit.Location = new System.Drawing.Point(17, 667);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 80);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Categories
            // 
            this.Categories.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Categories.ImageStream")));
            this.Categories.TransparentColor = System.Drawing.Color.Transparent;
            this.Categories.Images.SetKeyName(0, "Agriculture-Fruits-Vegetables.ico");
            this.Categories.Images.SetKeyName(1, "cut-of-meat.ico");
            this.Categories.Images.SetKeyName(2, "exit_icon.ico");
            this.Categories.Images.SetKeyName(3, "floppy_guardar_save_icon.ico");
            this.Categories.Images.SetKeyName(4, "Milk.ico");
            this.Categories.Images.SetKeyName(5, "Robinweatherall-Veggers-Green-Bean.ico");
            // 
            // buttonFruit
            // 
            this.buttonFruit.BackColor = System.Drawing.Color.LightGray;
            this.buttonFruit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFruit.ImageKey = "Agriculture-Fruits-Vegetables.ico";
            this.buttonFruit.ImageList = this.Categories;
            this.buttonFruit.Location = new System.Drawing.Point(17, 334);
            this.buttonFruit.Name = "buttonFruit";
            this.buttonFruit.Size = new System.Drawing.Size(118, 93);
            this.buttonFruit.TabIndex = 0;
            this.buttonFruit.UseVisualStyleBackColor = false;
            // 
            // buttonBean
            // 
            this.buttonBean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBean.ImageKey = "Robinweatherall-Veggers-Green-Bean.ico";
            this.buttonBean.ImageList = this.Categories;
            this.buttonBean.Location = new System.Drawing.Point(17, 235);
            this.buttonBean.Name = "buttonBean";
            this.buttonBean.Size = new System.Drawing.Size(118, 93);
            this.buttonBean.TabIndex = 0;
            this.buttonBean.UseVisualStyleBackColor = true;
            // 
            // buttonMilk
            // 
            this.buttonMilk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMilk.ImageKey = "Milk.ico";
            this.buttonMilk.ImageList = this.Categories;
            this.buttonMilk.Location = new System.Drawing.Point(17, 136);
            this.buttonMilk.Name = "buttonMilk";
            this.buttonMilk.Size = new System.Drawing.Size(118, 93);
            this.buttonMilk.TabIndex = 0;
            this.buttonMilk.UseVisualStyleBackColor = true;
            // 
            // buttonMeat
            // 
            this.buttonMeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMeat.ImageKey = "cut-of-meat.ico";
            this.buttonMeat.ImageList = this.Categories;
            this.buttonMeat.Location = new System.Drawing.Point(17, 37);
            this.buttonMeat.Name = "buttonMeat";
            this.buttonMeat.Size = new System.Drawing.Size(118, 93);
            this.buttonMeat.TabIndex = 0;
            this.buttonMeat.UseVisualStyleBackColor = true;
            // 
            // groupBoxCalculator
            // 
            this.groupBoxCalculator.Controls.Add(this.buttonEqual);
            this.groupBoxCalculator.Controls.Add(this.buttonPlus);
            this.groupBoxCalculator.Controls.Add(this.buttonMinus);
            this.groupBoxCalculator.Controls.Add(this.buttonDivide);
            this.groupBoxCalculator.Controls.Add(this.buttonMultiplication);
            this.groupBoxCalculator.Controls.Add(this.buttonThree);
            this.groupBoxCalculator.Controls.Add(this.buttonBackspace);
            this.groupBoxCalculator.Controls.Add(this.buttonSix);
            this.groupBoxCalculator.Controls.Add(this.buttonNine);
            this.groupBoxCalculator.Controls.Add(this.buttonZero);
            this.groupBoxCalculator.Controls.Add(this.buttonTwo);
            this.groupBoxCalculator.Controls.Add(this.buttonC);
            this.groupBoxCalculator.Controls.Add(this.buttonFive);
            this.groupBoxCalculator.Controls.Add(this.buttonEight);
            this.groupBoxCalculator.Controls.Add(this.buttonDot);
            this.groupBoxCalculator.Controls.Add(this.buttonOne);
            this.groupBoxCalculator.Controls.Add(this.buttonCE);
            this.groupBoxCalculator.Controls.Add(this.buttonFour);
            this.groupBoxCalculator.Controls.Add(this.buttonSeven);
            this.groupBoxCalculator.Controls.Add(this.textBoxCalculate);
            this.groupBoxCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxCalculator.Location = new System.Drawing.Point(839, 126);
            this.groupBoxCalculator.Name = "groupBoxCalculator";
            this.groupBoxCalculator.Size = new System.Drawing.Size(355, 565);
            this.groupBoxCalculator.TabIndex = 1;
            this.groupBoxCalculator.TabStop = false;
            this.groupBoxCalculator.Text = "Hesap Makinesi";
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEqual.ImageKey = "calculate_calculator_equal_equality_math_icon.ico";
            this.buttonEqual.ImageList = this.Calculator;
            this.buttonEqual.Location = new System.Drawing.Point(179, 469);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(158, 76);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // Calculator
            // 
            this.Calculator.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Calculator.ImageStream")));
            this.Calculator.TransparentColor = System.Drawing.Color.Transparent;
            this.Calculator.Images.SetKeyName(0, "add_addition_addition sign_calculator_math_icon.ico");
            this.Calculator.Images.SetKeyName(1, "backspace_back_icon.ico");
            this.Calculator.Images.SetKeyName(2, "calculate_calculator_divide_division_icon.ico");
            this.Calculator.Images.SetKeyName(3, "calculate_calculator_equal_equality_math_icon.ico");
            this.Calculator.Images.SetKeyName(4, "calculate_eliminate_hide_minus_soustract_icon.ico");
            this.Calculator.Images.SetKeyName(5, "calculator_math_multiplication_multiplication sign_multiply_icon.ico");
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.LightBlue;
            this.buttonPlus.ImageKey = "add_addition_addition sign_calculator_math_icon.ico";
            this.buttonPlus.ImageList = this.Calculator;
            this.buttonPlus.Location = new System.Drawing.Point(260, 387);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(77, 76);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.LightBlue;
            this.buttonMinus.ImageKey = "calculate_eliminate_hide_minus_soustract_icon.ico";
            this.buttonMinus.ImageList = this.Calculator;
            this.buttonMinus.Location = new System.Drawing.Point(260, 305);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(77, 76);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.LightBlue;
            this.buttonDivide.ImageKey = "calculate_calculator_divide_division_icon.ico";
            this.buttonDivide.ImageList = this.Calculator;
            this.buttonDivide.Location = new System.Drawing.Point(261, 141);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(77, 76);
            this.buttonDivide.TabIndex = 1;
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.LightBlue;
            this.buttonMultiplication.ImageKey = "calculator_math_multiplication_multiplication sign_multiply_icon.ico";
            this.buttonMultiplication.ImageList = this.Calculator;
            this.buttonMultiplication.Location = new System.Drawing.Point(260, 223);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(77, 76);
            this.buttonMultiplication.TabIndex = 1;
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonThree.Location = new System.Drawing.Point(177, 387);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(77, 76);
            this.buttonThree.TabIndex = 1;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBackspace.ImageKey = "backspace_back_icon.ico";
            this.buttonBackspace.ImageList = this.Calculator;
            this.buttonBackspace.Location = new System.Drawing.Point(178, 141);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(77, 76);
            this.buttonBackspace.TabIndex = 1;
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSix.Location = new System.Drawing.Point(177, 305);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(77, 76);
            this.buttonSix.TabIndex = 1;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNine.Location = new System.Drawing.Point(177, 223);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(77, 76);
            this.buttonNine.TabIndex = 1;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonZero.Location = new System.Drawing.Point(96, 469);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(77, 76);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTwo.Location = new System.Drawing.Point(96, 387);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(77, 76);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonC.Location = new System.Drawing.Point(97, 141);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(77, 76);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFive.Location = new System.Drawing.Point(96, 305);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(77, 76);
            this.buttonFive.TabIndex = 1;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEight.Location = new System.Drawing.Point(96, 223);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(77, 76);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDot.Location = new System.Drawing.Point(15, 469);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(77, 76);
            this.buttonDot.TabIndex = 1;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOne.Location = new System.Drawing.Point(15, 387);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(77, 76);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCE.Location = new System.Drawing.Point(16, 141);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(77, 76);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFour.Location = new System.Drawing.Point(15, 305);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(77, 76);
            this.buttonFour.TabIndex = 1;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeven.Location = new System.Drawing.Point(15, 223);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(77, 76);
            this.buttonSeven.TabIndex = 1;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // textBoxCalculate
            // 
            this.textBoxCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCalculate.Location = new System.Drawing.Point(16, 44);
            this.textBoxCalculate.Multiline = true;
            this.textBoxCalculate.Name = "textBoxCalculate";
            this.textBoxCalculate.Size = new System.Drawing.Size(322, 74);
            this.textBoxCalculate.TabIndex = 0;
            this.textBoxCalculate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSecond.Location = new System.Drawing.Point(1179, 13);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(27, 20);
            this.labelSecond.TabIndex = 9;
            this.labelSecond.Text = "00";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMinute.Location = new System.Drawing.Point(1151, 13);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(27, 20);
            this.labelMinute.TabIndex = 8;
            this.labelMinute.Text = "00";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHour.Location = new System.Drawing.Point(1122, 13);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(27, 20);
            this.labelHour.TabIndex = 7;
            this.labelHour.Text = "00";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.labelEggplant);
            this.groupBoxList.Controls.Add(this.labelOrange);
            this.groupBoxList.Controls.Add(this.labelBroccali);
            this.groupBoxList.Controls.Add(this.labelStrawberry);
            this.groupBoxList.Controls.Add(this.labelCabbage);
            this.groupBoxList.Controls.Add(this.labelBanana);
            this.groupBoxList.Controls.Add(this.labelApple);
            this.groupBoxList.Controls.Add(this.labelMelon);
            this.groupBoxList.Controls.Add(this.labelGrape);
            this.groupBoxList.Controls.Add(this.buttonEggplant);
            this.groupBoxList.Controls.Add(this.buttonOrange);
            this.groupBoxList.Controls.Add(this.buttonMelon);
            this.groupBoxList.Controls.Add(this.buttonStrawberry);
            this.groupBoxList.Controls.Add(this.buttonCabbage);
            this.groupBoxList.Controls.Add(this.buttonBroccali);
            this.groupBoxList.Controls.Add(this.buttonGrape);
            this.groupBoxList.Controls.Add(this.buttonBanana);
            this.groupBoxList.Controls.Add(this.buttonApple);
            this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxList.Location = new System.Drawing.Point(185, 295);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(648, 498);
            this.groupBoxList.TabIndex = 10;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Ürünler";
            // 
            // labelEggplant
            // 
            this.labelEggplant.AutoSize = true;
            this.labelEggplant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEggplant.Location = new System.Drawing.Point(482, 340);
            this.labelEggplant.Name = "labelEggplant";
            this.labelEggplant.Size = new System.Drawing.Size(37, 16);
            this.labelEggplant.TabIndex = 1;
            this.labelEggplant.Text = "8 TL";
            // 
            // labelOrange
            // 
            this.labelOrange.AutoSize = true;
            this.labelOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrange.Location = new System.Drawing.Point(482, 180);
            this.labelOrange.Name = "labelOrange";
            this.labelOrange.Size = new System.Drawing.Size(37, 16);
            this.labelOrange.TabIndex = 1;
            this.labelOrange.Text = "7 TL";
            // 
            // labelBroccali
            // 
            this.labelBroccali.AutoSize = true;
            this.labelBroccali.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBroccali.Location = new System.Drawing.Point(482, 21);
            this.labelBroccali.Name = "labelBroccali";
            this.labelBroccali.Size = new System.Drawing.Size(37, 16);
            this.labelBroccali.TabIndex = 1;
            this.labelBroccali.Text = "5 TL";
            // 
            // labelStrawberry
            // 
            this.labelStrawberry.AutoSize = true;
            this.labelStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStrawberry.Location = new System.Drawing.Point(299, 340);
            this.labelStrawberry.Name = "labelStrawberry";
            this.labelStrawberry.Size = new System.Drawing.Size(45, 16);
            this.labelStrawberry.TabIndex = 1;
            this.labelStrawberry.Text = "14 TL";
            // 
            // labelCabbage
            // 
            this.labelCabbage.AutoSize = true;
            this.labelCabbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCabbage.Location = new System.Drawing.Point(299, 181);
            this.labelCabbage.Name = "labelCabbage";
            this.labelCabbage.Size = new System.Drawing.Size(45, 16);
            this.labelCabbage.TabIndex = 1;
            this.labelCabbage.Text = "15 TL";
            // 
            // labelBanana
            // 
            this.labelBanana.AutoSize = true;
            this.labelBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBanana.Location = new System.Drawing.Point(303, 22);
            this.labelBanana.Name = "labelBanana";
            this.labelBanana.Size = new System.Drawing.Size(45, 16);
            this.labelBanana.TabIndex = 1;
            this.labelBanana.Text = "12 TL";
            // 
            // labelApple
            // 
            this.labelApple.AutoSize = true;
            this.labelApple.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelApple.Location = new System.Drawing.Point(128, 22);
            this.labelApple.Name = "labelApple";
            this.labelApple.Size = new System.Drawing.Size(45, 16);
            this.labelApple.TabIndex = 1;
            this.labelApple.Text = "10 TL";
            // 
            // labelMelon
            // 
            this.labelMelon.AutoSize = true;
            this.labelMelon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMelon.Location = new System.Drawing.Point(128, 341);
            this.labelMelon.Name = "labelMelon";
            this.labelMelon.Size = new System.Drawing.Size(37, 16);
            this.labelMelon.TabIndex = 1;
            this.labelMelon.Text = "2 TL";
            // 
            // labelGrape
            // 
            this.labelGrape.AutoSize = true;
            this.labelGrape.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGrape.Location = new System.Drawing.Point(128, 181);
            this.labelGrape.Name = "labelGrape";
            this.labelGrape.Size = new System.Drawing.Size(45, 16);
            this.labelGrape.TabIndex = 1;
            this.labelGrape.Text = "11 TL";
            // 
            // buttonEggplant
            // 
            this.buttonEggplant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEggplant.ImageKey = "Eggplant.ico";
            this.buttonEggplant.ImageList = this.FruitVegetables;
            this.buttonEggplant.Location = new System.Drawing.Point(444, 360);
            this.buttonEggplant.Name = "buttonEggplant";
            this.buttonEggplant.Size = new System.Drawing.Size(125, 128);
            this.buttonEggplant.TabIndex = 0;
            this.buttonEggplant.UseVisualStyleBackColor = true;
            // 
            // FruitVegetables
            // 
            this.FruitVegetables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FruitVegetables.ImageStream")));
            this.FruitVegetables.TransparentColor = System.Drawing.Color.Transparent;
            this.FruitVegetables.Images.SetKeyName(0, "broccoli.ico");
            this.FruitVegetables.Images.SetKeyName(1, "Fruitsalad-Apple.ico");
            this.FruitVegetables.Images.SetKeyName(2, "Fruits-Strawberry.ico");
            this.FruitVegetables.Images.SetKeyName(3, "Fruit-Vegetables-Orange.ico");
            this.FruitVegetables.Images.SetKeyName(4, "grapes.ico");
            this.FruitVegetables.Images.SetKeyName(5, "Vegetables-Cabbage.ico");
            this.FruitVegetables.Images.SetKeyName(6, "Veggies-Bananas.ico");
            this.FruitVegetables.Images.SetKeyName(7, "Eggplant.ico");
            this.FruitVegetables.Images.SetKeyName(8, "Fruit-Watermelon.ico");
            // 
            // buttonOrange
            // 
            this.buttonOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrange.ImageKey = "Fruit-Vegetables-Orange.ico";
            this.buttonOrange.ImageList = this.FruitVegetables;
            this.buttonOrange.Location = new System.Drawing.Point(444, 200);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(125, 128);
            this.buttonOrange.TabIndex = 0;
            this.buttonOrange.UseVisualStyleBackColor = true;
            // 
            // buttonMelon
            // 
            this.buttonMelon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMelon.ImageKey = "Fruit-Watermelon.ico";
            this.buttonMelon.ImageList = this.FruitVegetables;
            this.buttonMelon.Location = new System.Drawing.Point(89, 360);
            this.buttonMelon.Name = "buttonMelon";
            this.buttonMelon.Size = new System.Drawing.Size(125, 128);
            this.buttonMelon.TabIndex = 0;
            this.buttonMelon.UseVisualStyleBackColor = true;
            // 
            // buttonStrawberry
            // 
            this.buttonStrawberry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStrawberry.ImageKey = "Fruits-Strawberry.ico";
            this.buttonStrawberry.ImageList = this.FruitVegetables;
            this.buttonStrawberry.Location = new System.Drawing.Point(266, 360);
            this.buttonStrawberry.Name = "buttonStrawberry";
            this.buttonStrawberry.Size = new System.Drawing.Size(125, 128);
            this.buttonStrawberry.TabIndex = 0;
            this.buttonStrawberry.UseVisualStyleBackColor = true;
            // 
            // buttonCabbage
            // 
            this.buttonCabbage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCabbage.ImageKey = "Vegetables-Cabbage.ico";
            this.buttonCabbage.ImageList = this.FruitVegetables;
            this.buttonCabbage.Location = new System.Drawing.Point(266, 200);
            this.buttonCabbage.Name = "buttonCabbage";
            this.buttonCabbage.Size = new System.Drawing.Size(125, 128);
            this.buttonCabbage.TabIndex = 0;
            this.buttonCabbage.UseVisualStyleBackColor = true;
            // 
            // buttonBroccali
            // 
            this.buttonBroccali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBroccali.ImageKey = "broccoli.ico";
            this.buttonBroccali.ImageList = this.FruitVegetables;
            this.buttonBroccali.Location = new System.Drawing.Point(444, 41);
            this.buttonBroccali.Name = "buttonBroccali";
            this.buttonBroccali.Size = new System.Drawing.Size(125, 128);
            this.buttonBroccali.TabIndex = 0;
            this.buttonBroccali.UseVisualStyleBackColor = true;
            // 
            // buttonGrape
            // 
            this.buttonGrape.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrape.ImageKey = "grapes.ico";
            this.buttonGrape.ImageList = this.FruitVegetables;
            this.buttonGrape.Location = new System.Drawing.Point(89, 200);
            this.buttonGrape.Name = "buttonGrape";
            this.buttonGrape.Size = new System.Drawing.Size(125, 128);
            this.buttonGrape.TabIndex = 0;
            this.buttonGrape.UseVisualStyleBackColor = true;
            // 
            // buttonBanana
            // 
            this.buttonBanana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBanana.ImageKey = "Veggies-Bananas.ico";
            this.buttonBanana.ImageList = this.FruitVegetables;
            this.buttonBanana.Location = new System.Drawing.Point(266, 41);
            this.buttonBanana.Name = "buttonBanana";
            this.buttonBanana.Size = new System.Drawing.Size(125, 128);
            this.buttonBanana.TabIndex = 0;
            this.buttonBanana.UseVisualStyleBackColor = true;
            // 
            // buttonApple
            // 
            this.buttonApple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApple.ImageKey = "Fruitsalad-Apple.ico";
            this.buttonApple.ImageList = this.FruitVegetables;
            this.buttonApple.Location = new System.Drawing.Point(89, 41);
            this.buttonApple.Name = "buttonApple";
            this.buttonApple.Size = new System.Drawing.Size(125, 128);
            this.buttonApple.TabIndex = 0;
            this.buttonApple.UseVisualStyleBackColor = true;
            // 
            // groupBoxScan
            // 
            this.groupBoxScan.Controls.Add(this.textBoxBarcodeCode);
            this.groupBoxScan.Controls.Add(this.buttonTurnOffCamera);
            this.groupBoxScan.Controls.Add(this.buttonTurnOnCamera);
            this.groupBoxScan.Controls.Add(this.pictureBoxCamera);
            this.groupBoxScan.Controls.Add(this.labelProductName);
            this.groupBoxScan.Controls.Add(this.label3);
            this.groupBoxScan.Controls.Add(this.label2);
            this.groupBoxScan.Controls.Add(this.label1);
            this.groupBoxScan.Controls.Add(this.comboBoxChooseCamera);
            this.groupBoxScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxScan.Location = new System.Drawing.Point(185, 13);
            this.groupBoxScan.Name = "groupBoxScan";
            this.groupBoxScan.Size = new System.Drawing.Size(648, 270);
            this.groupBoxScan.TabIndex = 11;
            this.groupBoxScan.TabStop = false;
            this.groupBoxScan.Text = "Ürünü Okut";
            // 
            // textBoxBarcodeCode
            // 
            this.textBoxBarcodeCode.Location = new System.Drawing.Point(19, 219);
            this.textBoxBarcodeCode.Name = "textBoxBarcodeCode";
            this.textBoxBarcodeCode.Size = new System.Drawing.Size(329, 22);
            this.textBoxBarcodeCode.TabIndex = 5;
            this.textBoxBarcodeCode.TextChanged += new System.EventHandler(this.textBoxBarcodeCode_TextChanged);
            // 
            // buttonTurnOffCamera
            // 
            this.buttonTurnOffCamera.Location = new System.Drawing.Point(146, 113);
            this.buttonTurnOffCamera.Name = "buttonTurnOffCamera";
            this.buttonTurnOffCamera.Size = new System.Drawing.Size(198, 30);
            this.buttonTurnOffCamera.TabIndex = 4;
            this.buttonTurnOffCamera.Text = "Kamerayı Kapat";
            this.buttonTurnOffCamera.UseVisualStyleBackColor = true;
            this.buttonTurnOffCamera.Click += new System.EventHandler(this.buttonTurnOffCamera_Click);
            // 
            // buttonTurnOnCamera
            // 
            this.buttonTurnOnCamera.Location = new System.Drawing.Point(146, 72);
            this.buttonTurnOnCamera.Name = "buttonTurnOnCamera";
            this.buttonTurnOnCamera.Size = new System.Drawing.Size(198, 30);
            this.buttonTurnOnCamera.TabIndex = 3;
            this.buttonTurnOnCamera.Text = "Kamerayı Aç";
            this.buttonTurnOnCamera.UseVisualStyleBackColor = true;
            this.buttonTurnOnCamera.Click += new System.EventHandler(this.buttonTurnOnCamera_Click);
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCamera.Image")));
            this.pictureBoxCamera.InitialImage = null;
            this.pictureBoxCamera.Location = new System.Drawing.Point(368, 13);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(256, 251);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamera.TabIndex = 2;
            this.pictureBoxCamera.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.ForeColor = System.Drawing.Color.Red;
            this.labelProductName.Location = new System.Drawing.Point(108, 173);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(11, 16);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kamera Seç :";
            // 
            // comboBoxChooseCamera
            // 
            this.comboBoxChooseCamera.FormattingEnabled = true;
            this.comboBoxChooseCamera.Location = new System.Drawing.Point(146, 35);
            this.comboBoxChooseCamera.Name = "comboBoxChooseCamera";
            this.comboBoxChooseCamera.Size = new System.Drawing.Size(198, 24);
            this.comboBoxChooseCamera.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBarcode
            // 
            this.timerBarcode.Tick += new System.EventHandler(this.timerBarcode_Tick);
            // 
            // FruitVegetablePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 808);
            this.Controls.Add(this.groupBoxScan);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.groupBoxCalculator);
            this.Controls.Add(this.groupBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FruitVegetablePanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meyve Sebze Paneli";
            this.Load += new System.EventHandler(this.FruitVegetablePanelForm_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxCalculator.ResumeLayout(false);
            this.groupBoxCalculator.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.groupBoxScan.ResumeLayout(false);
            this.groupBoxScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonMeat;
        private System.Windows.Forms.ImageList Categories;
        private System.Windows.Forms.Button buttonFruit;
        private System.Windows.Forms.Button buttonBean;
        private System.Windows.Forms.Button buttonMilk;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxCalculator;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxScan;
        private System.Windows.Forms.ComboBox comboBoxChooseCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Button buttonTurnOnCamera;
        private System.Windows.Forms.TextBox textBoxCalculate;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.ImageList Calculator;
        private System.Windows.Forms.Button buttonApple;
        private System.Windows.Forms.ImageList FruitVegetables;
        private System.Windows.Forms.Button buttonBroccali;
        private System.Windows.Forms.Button buttonBanana;
        private System.Windows.Forms.Button buttonEggplant;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonMelon;
        private System.Windows.Forms.Button buttonStrawberry;
        private System.Windows.Forms.Button buttonCabbage;
        private System.Windows.Forms.Button buttonGrape;
        private System.Windows.Forms.Label labelGrape;
        private System.Windows.Forms.Label labelEggplant;
        private System.Windows.Forms.Label labelOrange;
        private System.Windows.Forms.Label labelBroccali;
        private System.Windows.Forms.Label labelStrawberry;
        private System.Windows.Forms.Label labelCabbage;
        private System.Windows.Forms.Label labelBanana;
        private System.Windows.Forms.Label labelApple;
        private System.Windows.Forms.Label labelMelon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonTurnOffCamera;
        private System.Windows.Forms.TextBox textBoxBarcodeCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerBarcode;
    }
}