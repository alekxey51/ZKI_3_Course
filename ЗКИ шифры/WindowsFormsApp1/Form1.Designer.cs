namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column123 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new Guna.UI.WinForms.GunaRadioButton();
            this.checkBox4 = new Guna.UI.WinForms.GunaRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox5 = new Guna.UI.WinForms.GunaRadioButton();
            this.checkBox1 = new Guna.UI.WinForms.GunaRadioButton();
            this.checkBox2 = new Guna.UI.WinForms.GunaRadioButton();
            this.textBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.textBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.textBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.textBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI.WinForms.GunaButton();
            this.button3 = new Guna.UI.WinForms.GunaButton();
            this.button2 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.textBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.textBox6 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "а=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "а=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "b=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Исходный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Действия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Зашифрованный текст";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column123});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 246);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 167);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // column123
            // 
            this.column123.Text = "";
            this.column123.Width = 571;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 39);
            this.panel1.TabIndex = 21;
            // 
            // checkBox3
            // 
            this.checkBox3.BaseColor = System.Drawing.SystemColors.Control;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox3.CheckedOnColor = System.Drawing.Color.Silver;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FillColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(19, 10);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 20);
            this.checkBox3.TabIndex = 46;
            this.checkBox3.Text = "RUS";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.BaseColor = System.Drawing.SystemColors.Control;
            this.checkBox4.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox4.CheckedOnColor = System.Drawing.Color.Silver;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FillColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(79, 11);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 20);
            this.checkBox4.TabIndex = 47;
            this.checkBox4.Text = "ENG";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(477, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 41);
            this.panel2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(487, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Язык";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(477, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 196);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.checkBox5);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 194);
            this.panel4.TabIndex = 21;
            // 
            // checkBox5
            // 
            this.checkBox5.BaseColor = System.Drawing.SystemColors.Control;
            this.checkBox5.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox5.CheckedOnColor = System.Drawing.Color.Silver;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FillColor = System.Drawing.Color.White;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.Location = new System.Drawing.Point(6, 142);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(110, 20);
            this.checkBox5.TabIndex = 50;
            this.checkBox5.Text = "Другая Формула";
            // 
            // checkBox1
            // 
            this.checkBox1.BaseColor = System.Drawing.SystemColors.Control;
            this.checkBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox1.CheckedOnColor = System.Drawing.Color.Silver;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FillColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(6, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 20);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Формула K = ap+1";
            // 
            // checkBox2
            // 
            this.checkBox2.BaseColor = System.Drawing.SystemColors.Control;
            this.checkBox2.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox2.CheckedOnColor = System.Drawing.Color.Silver;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FillColor = System.Drawing.Color.White;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(6, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 20);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "Формула K = ap^2+bp-7";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Transparent;
            this.textBox5.BaseColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderColor = System.Drawing.Color.Silver;
            this.textBox5.BorderSize = 1;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.textBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox5.Location = new System.Drawing.Point(9, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '\0';
            this.textBox5.Radius = 10;
            this.textBox5.Size = new System.Drawing.Size(131, 26);
            this.textBox5.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Transparent;
            this.textBox3.BaseColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderColor = System.Drawing.Color.Silver;
            this.textBox3.BorderSize = 1;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.textBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox3.Location = new System.Drawing.Point(53, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.Radius = 10;
            this.textBox3.Size = new System.Drawing.Size(50, 26);
            this.textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.BaseColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderColor = System.Drawing.Color.Silver;
            this.textBox2.BorderSize = 1;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.textBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(53, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.Radius = 10;
            this.textBox2.Size = new System.Drawing.Size(50, 26);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.BaseColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderColor = System.Drawing.Color.Silver;
            this.textBox1.BorderSize = 1;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.textBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(53, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.Radius = 10;
            this.textBox1.Size = new System.Drawing.Size(50, 26);
            this.textBox1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(487, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Формула";
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
            this.button1.Location = new System.Drawing.Point(475, 345);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.Black;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Radius = 5;
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Зашифровать -->";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AnimationHoverSpeed = 0.07F;
            this.button3.AnimationSpeed = 0.03F;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BaseColor = System.Drawing.Color.LightGray;
            this.button3.BorderColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button3.FocusedColor = System.Drawing.Color.Empty;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = null;
            this.button3.ImageSize = new System.Drawing.Size(20, 20);
            this.button3.Location = new System.Drawing.Point(475, 382);
            this.button3.Name = "button3";
            this.button3.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.button3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button3.OnHoverForeColor = System.Drawing.Color.Black;
            this.button3.OnHoverImage = null;
            this.button3.OnPressedColor = System.Drawing.Color.Black;
            this.button3.Radius = 5;
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 27;
            this.button3.Text = "<-- Расшифровать";
            this.button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.AnimationHoverSpeed = 0.07F;
            this.button2.AnimationSpeed = 0.03F;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.LightGray;
            this.button2.BorderColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2.FocusedColor = System.Drawing.Color.Empty;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = null;
            this.button2.ImageSize = new System.Drawing.Size(20, 20);
            this.button2.Location = new System.Drawing.Point(586, 345);
            this.button2.Name = "button2";
            this.button2.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.button2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button2.OnHoverForeColor = System.Drawing.Color.Black;
            this.button2.OnHoverImage = null;
            this.button2.OnPressedColor = System.Drawing.Color.Black;
            this.button2.Radius = 5;
            this.button2.Size = new System.Drawing.Size(45, 70);
            this.button2.TabIndex = 28;
            this.button2.Text = "Menu";
            this.button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel1.Location = new System.Drawing.Point(616, 5);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(17, 17);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Х";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Transparent;
            this.textBox4.BaseColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderColor = System.Drawing.Color.Silver;
            this.textBox4.BorderSize = 1;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.textBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox4.Location = new System.Drawing.Point(10, 53);
            this.textBox4.MultiLine = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '\0';
            this.textBox4.Radius = 10;
            this.textBox4.Size = new System.Drawing.Size(459, 72);
            this.textBox4.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Transparent;
            this.textBox6.BaseColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderColor = System.Drawing.Color.Silver;
            this.textBox6.BorderSize = 1;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.textBox6.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox6.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox6.Location = new System.Drawing.Point(10, 150);
            this.textBox6.MultiLine = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '\0';
            this.textBox6.Radius = 10;
            this.textBox6.Size = new System.Drawing.Size(459, 72);
            this.textBox6.TabIndex = 31;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(227, -9);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(186, 38);
            this.gunaElipsePanel1.TabIndex = 45;
            this.gunaElipsePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.gunaElipsePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 17);
            this.gunaLabel2.TabIndex = 43;
            this.gunaLabel2.Text = "Улучшенный Цезарь";
            this.gunaLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.gunaLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 425);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(640, 468);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column123;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton button1;
        private Guna.UI.WinForms.GunaButton button3;
        private Guna.UI.WinForms.GunaButton button2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox textBox1;
        private Guna.UI.WinForms.GunaTextBox textBox6;
        private Guna.UI.WinForms.GunaTextBox textBox4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox textBox5;
        private Guna.UI.WinForms.GunaTextBox textBox3;
        private Guna.UI.WinForms.GunaTextBox textBox2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaRadioButton checkBox3;
        private Guna.UI.WinForms.GunaRadioButton checkBox4;
        private Guna.UI.WinForms.GunaRadioButton checkBox1;
        private Guna.UI.WinForms.GunaRadioButton checkBox5;
        private Guna.UI.WinForms.GunaRadioButton checkBox2;
    }
}

