namespace WindowsFormsApp1
{
    partial class Vishiera
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.radioRus = new Guna.UI.WinForms.GunaRadioButton();
            this.radioEng = new Guna.UI.WinForms.GunaRadioButton();
            this.button1 = new Guna.UI.WinForms.GunaButton();
            this.btnDecode = new Guna.UI.WinForms.GunaButton();
            this.btnEncode = new Guna.UI.WinForms.GunaButton();
            this.tboxSource = new Guna.UI.WinForms.GunaTextBox();
            this.tboxKeyword = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDecoded = new Guna.UI.WinForms.GunaTextBox();
            this.tboxEncoded = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaRadioButton1 = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaRadioButton2 = new Guna.UI.WinForms.GunaRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(263, -9);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(186, 38);
            this.gunaElipsePanel1.TabIndex = 45;
            this.gunaElipsePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vishiera_MouseDown);
            this.gunaElipsePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vishiera_MouseMove);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.Location = new System.Drawing.Point(37, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 17);
            this.gunaLabel2.TabIndex = 43;
            this.gunaLabel2.Text = "Шифр Виженера";
            this.gunaLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vishiera_MouseDown);
            this.gunaLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vishiera_MouseMove);
            // 
            // radioRus
            // 
            this.radioRus.BaseColor = System.Drawing.SystemColors.Control;
            this.radioRus.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioRus.CheckedOnColor = System.Drawing.Color.Silver;
            this.radioRus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRus.FillColor = System.Drawing.Color.White;
            this.radioRus.Location = new System.Drawing.Point(86, 3);
            this.radioRus.Name = "radioRus";
            this.radioRus.Size = new System.Drawing.Size(54, 20);
            this.radioRus.TabIndex = 55;
            this.radioRus.Text = "RUS";
            this.radioRus.CheckedChanged += new System.EventHandler(this.radioRus_CheckedChanged);
            // 
            // radioEng
            // 
            this.radioEng.BaseColor = System.Drawing.SystemColors.Control;
            this.radioEng.Checked = true;
            this.radioEng.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioEng.CheckedOnColor = System.Drawing.Color.Silver;
            this.radioEng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEng.FillColor = System.Drawing.Color.White;
            this.radioEng.Location = new System.Drawing.Point(26, 3);
            this.radioEng.Name = "radioEng";
            this.radioEng.Size = new System.Drawing.Size(54, 20);
            this.radioEng.TabIndex = 54;
            this.radioEng.Text = "ENG";
            this.radioEng.CheckedChanged += new System.EventHandler(this.radioEng_CheckedChanged);
            // 
            // button1
            // 
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.LightGray;
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = null;
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(629, 337);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.Black;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Radius = 5;
            this.button1.Size = new System.Drawing.Size(48, 64);
            this.button1.TabIndex = 53;
            this.button1.Text = "Menu";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.AnimationHoverSpeed = 0.07F;
            this.btnDecode.AnimationSpeed = 0.03F;
            this.btnDecode.BackColor = System.Drawing.Color.Transparent;
            this.btnDecode.BaseColor = System.Drawing.Color.LightGray;
            this.btnDecode.BorderColor = System.Drawing.Color.Black;
            this.btnDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecode.FocusedColor = System.Drawing.Color.Empty;
            this.btnDecode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecode.ForeColor = System.Drawing.Color.Black;
            this.btnDecode.Image = null;
            this.btnDecode.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDecode.Location = new System.Drawing.Point(519, 371);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnDecode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDecode.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDecode.OnHoverImage = null;
            this.btnDecode.OnPressedColor = System.Drawing.Color.Black;
            this.btnDecode.Radius = 5;
            this.btnDecode.Size = new System.Drawing.Size(106, 30);
            this.btnDecode.TabIndex = 52;
            this.btnDecode.Text = "<-- Расшифровать";
            this.btnDecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.AnimationHoverSpeed = 0.07F;
            this.btnEncode.AnimationSpeed = 0.03F;
            this.btnEncode.BackColor = System.Drawing.Color.Transparent;
            this.btnEncode.BaseColor = System.Drawing.Color.LightGray;
            this.btnEncode.BorderColor = System.Drawing.Color.Black;
            this.btnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEncode.FocusedColor = System.Drawing.Color.Empty;
            this.btnEncode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncode.ForeColor = System.Drawing.Color.Black;
            this.btnEncode.Image = null;
            this.btnEncode.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEncode.Location = new System.Drawing.Point(519, 337);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnEncode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEncode.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEncode.OnHoverImage = null;
            this.btnEncode.OnPressedColor = System.Drawing.Color.Black;
            this.btnEncode.Radius = 5;
            this.btnEncode.Size = new System.Drawing.Size(106, 30);
            this.btnEncode.TabIndex = 51;
            this.btnEncode.Text = "Зашифровать -->";
            this.btnEncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // tboxSource
            // 
            this.tboxSource.BackColor = System.Drawing.Color.Transparent;
            this.tboxSource.BaseColor = System.Drawing.SystemColors.Control;
            this.tboxSource.BorderColor = System.Drawing.Color.Silver;
            this.tboxSource.BorderSize = 1;
            this.tboxSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxSource.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.tboxSource.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboxSource.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tboxSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxSource.Location = new System.Drawing.Point(10, 56);
            this.tboxSource.MultiLine = true;
            this.tboxSource.Name = "tboxSource";
            this.tboxSource.PasswordChar = '\0';
            this.tboxSource.Radius = 10;
            this.tboxSource.Size = new System.Drawing.Size(245, 345);
            this.tboxSource.TabIndex = 1;
            // 
            // tboxKeyword
            // 
            this.tboxKeyword.BackColor = System.Drawing.Color.Transparent;
            this.tboxKeyword.BaseColor = System.Drawing.SystemColors.Control;
            this.tboxKeyword.BorderColor = System.Drawing.Color.Silver;
            this.tboxKeyword.BorderSize = 1;
            this.tboxKeyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxKeyword.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.tboxKeyword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboxKeyword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tboxKeyword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxKeyword.Location = new System.Drawing.Point(520, 176);
            this.tboxKeyword.Name = "tboxKeyword";
            this.tboxKeyword.PasswordChar = '\0';
            this.tboxKeyword.Radius = 10;
            this.tboxKeyword.Size = new System.Drawing.Size(157, 26);
            this.tboxKeyword.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Выбор языка кодировки:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Исходный текст:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Кодовое слово:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxDecoded
            // 
            this.tboxDecoded.BackColor = System.Drawing.Color.Transparent;
            this.tboxDecoded.BaseColor = System.Drawing.SystemColors.Control;
            this.tboxDecoded.BorderColor = System.Drawing.Color.Silver;
            this.tboxDecoded.BorderSize = 1;
            this.tboxDecoded.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxDecoded.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.tboxDecoded.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboxDecoded.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tboxDecoded.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxDecoded.Location = new System.Drawing.Point(263, 238);
            this.tboxDecoded.MultiLine = true;
            this.tboxDecoded.Name = "tboxDecoded";
            this.tboxDecoded.PasswordChar = '\0';
            this.tboxDecoded.Radius = 10;
            this.tboxDecoded.Size = new System.Drawing.Size(245, 163);
            this.tboxDecoded.TabIndex = 59;
            // 
            // tboxEncoded
            // 
            this.tboxEncoded.BackColor = System.Drawing.Color.Transparent;
            this.tboxEncoded.BaseColor = System.Drawing.SystemColors.Control;
            this.tboxEncoded.BorderColor = System.Drawing.Color.Silver;
            this.tboxEncoded.BorderSize = 1;
            this.tboxEncoded.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxEncoded.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.tboxEncoded.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboxEncoded.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tboxEncoded.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxEncoded.Location = new System.Drawing.Point(263, 56);
            this.tboxEncoded.MultiLine = true;
            this.tboxEncoded.Name = "tboxEncoded";
            this.tboxEncoded.PasswordChar = '\0';
            this.tboxEncoded.Radius = 10;
            this.tboxEncoded.Size = new System.Drawing.Size(245, 163);
            this.tboxEncoded.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Расшифрованный текст:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Зашифрованный текст:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaRadioButton1
            // 
            this.gunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton1.CheckedOnColor = System.Drawing.Color.Silver;
            this.gunaRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaRadioButton1.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton1.Location = new System.Drawing.Point(84, 3);
            this.gunaRadioButton1.Name = "gunaRadioButton1";
            this.gunaRadioButton1.Size = new System.Drawing.Size(65, 20);
            this.gunaRadioButton1.TabIndex = 62;
            this.gunaRadioButton1.Text = "A+A=Б";
            this.gunaRadioButton1.CheckedChanged += new System.EventHandler(this.gunaRadioButton1_CheckedChanged);
            // 
            // gunaRadioButton2
            // 
            this.gunaRadioButton2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton2.Checked = true;
            this.gunaRadioButton2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton2.CheckedOnColor = System.Drawing.Color.Silver;
            this.gunaRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaRadioButton2.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton2.Location = new System.Drawing.Point(24, 3);
            this.gunaRadioButton2.Name = "gunaRadioButton2";
            this.gunaRadioButton2.Size = new System.Drawing.Size(66, 20);
            this.gunaRadioButton2.TabIndex = 61;
            this.gunaRadioButton2.Text = "А+А=А";
            this.gunaRadioButton2.CheckedChanged += new System.EventHandler(this.gunaRadioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Выбор метод шифрования";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel1.Location = new System.Drawing.Point(664, 5);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(17, 17);
            this.gunaLabel1.TabIndex = 63;
            this.gunaLabel1.Text = "Х";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.radioRus);
            this.gunaPanel1.Controls.Add(this.radioEng);
            this.gunaPanel1.Location = new System.Drawing.Point(516, 66);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(167, 26);
            this.gunaPanel1.TabIndex = 64;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaRadioButton1);
            this.gunaPanel2.Controls.Add(this.gunaRadioButton2);
            this.gunaPanel2.Location = new System.Drawing.Point(516, 121);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(167, 26);
            this.gunaPanel2.TabIndex = 65;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(520, 301);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(106, 30);
            this.gunaButton1.TabIndex = 66;
            this.gunaButton1.Text = "<-- Расшифровать";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Visible = false;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.LightGray;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(519, 303);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(158, 30);
            this.gunaButton2.TabIndex = 67;
            this.gunaButton2.Text = "Таблица";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // Vishiera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 413);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxDecoded);
            this.Controls.Add(this.tboxEncoded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.tboxSource);
            this.Controls.Add(this.tboxKeyword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vishiera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vishiera";
            this.Load += new System.EventHandler(this.Vishiera_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vishiera_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vishiera_MouseMove);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaRadioButton radioRus;
        private Guna.UI.WinForms.GunaRadioButton radioEng;
        private Guna.UI.WinForms.GunaButton button1;
        private Guna.UI.WinForms.GunaButton btnDecode;
        private Guna.UI.WinForms.GunaButton btnEncode;
        private Guna.UI.WinForms.GunaTextBox tboxSource;
        private Guna.UI.WinForms.GunaTextBox tboxKeyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox tboxDecoded;
        private Guna.UI.WinForms.GunaTextBox tboxEncoded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton1;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}