namespace WindowsFormsApp1
{
    partial class Playfera
    {

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
            this.label1 = new System.Windows.Forms.Label();
            this.lvMatrix = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tboxKeyword = new Guna.UI.WinForms.GunaTextBox();
            this.tboxBigramma = new Guna.UI.WinForms.GunaTextBox();
            this.tboxEncoded = new Guna.UI.WinForms.GunaTextBox();
            this.tboxDecoded = new Guna.UI.WinForms.GunaTextBox();
            this.tboxSource = new Guna.UI.WinForms.GunaTextBox();
            this.btnEncode = new Guna.UI.WinForms.GunaButton();
            this.btnDecode = new Guna.UI.WinForms.GunaButton();
            this.button1 = new Guna.UI.WinForms.GunaButton();
            this.radioEng = new Guna.UI.WinForms.GunaRadioButton();
            this.radioRus = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кодовое слово:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvMatrix
            // 
            this.lvMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMatrix.BackColor = System.Drawing.SystemColors.Control;
            this.lvMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMatrix.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMatrix.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvMatrix.GridLines = true;
            this.lvMatrix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMatrix.HideSelection = false;
            this.lvMatrix.Location = new System.Drawing.Point(525, 131);
            this.lvMatrix.MultiSelect = false;
            this.lvMatrix.Name = "lvMatrix";
            this.lvMatrix.Scrollable = false;
            this.lvMatrix.ShowGroups = false;
            this.lvMatrix.Size = new System.Drawing.Size(150, 130);
            this.lvMatrix.TabIndex = 3;
            this.lvMatrix.UseCompatibleStateImageBehavior = false;
            this.lvMatrix.View = System.Windows.Forms.View.Details;
            this.lvMatrix.VirtualListSize = 5;
            this.lvMatrix.VirtualMode = true;
            this.lvMatrix.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvMatrix_RetrieveVirtualItem);
            this.lvMatrix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseDown);
            this.lvMatrix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выбор языка кодировки:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Исходный текст:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Биграмма:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Зашифрованный текст:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Расшифрованный текст:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.gunaLabel1.Location = new System.Drawing.Point(665, 5);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(17, 17);
            this.gunaLabel1.TabIndex = 30;
            this.gunaLabel1.Text = "Х";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
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
            this.tboxKeyword.Location = new System.Drawing.Point(518, 99);
            this.tboxKeyword.Name = "tboxKeyword";
            this.tboxKeyword.PasswordChar = '\0';
            this.tboxKeyword.Radius = 10;
            this.tboxKeyword.Size = new System.Drawing.Size(157, 26);
            this.tboxKeyword.TabIndex = 33;
            // 
            // tboxBigramma
            // 
            this.tboxBigramma.BackColor = System.Drawing.Color.Transparent;
            this.tboxBigramma.BaseColor = System.Drawing.SystemColors.Control;
            this.tboxBigramma.BorderColor = System.Drawing.Color.Silver;
            this.tboxBigramma.BorderSize = 1;
            this.tboxBigramma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxBigramma.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.tboxBigramma.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboxBigramma.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tboxBigramma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxBigramma.Location = new System.Drawing.Point(265, 56);
            this.tboxBigramma.MultiLine = true;
            this.tboxBigramma.Name = "tboxBigramma";
            this.tboxBigramma.PasswordChar = '\0';
            this.tboxBigramma.Radius = 10;
            this.tboxBigramma.Size = new System.Drawing.Size(245, 163);
            this.tboxBigramma.TabIndex = 34;
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
            this.tboxEncoded.Location = new System.Drawing.Point(265, 246);
            this.tboxEncoded.MultiLine = true;
            this.tboxEncoded.Name = "tboxEncoded";
            this.tboxEncoded.PasswordChar = '\0';
            this.tboxEncoded.Radius = 10;
            this.tboxEncoded.Size = new System.Drawing.Size(245, 163);
            this.tboxEncoded.TabIndex = 35;
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
            this.tboxDecoded.Location = new System.Drawing.Point(10, 246);
            this.tboxDecoded.MultiLine = true;
            this.tboxDecoded.Name = "tboxDecoded";
            this.tboxDecoded.PasswordChar = '\0';
            this.tboxDecoded.Radius = 10;
            this.tboxDecoded.Size = new System.Drawing.Size(245, 163);
            this.tboxDecoded.TabIndex = 36;
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
            this.tboxSource.Size = new System.Drawing.Size(245, 163);
            this.tboxSource.TabIndex = 37;
            this.tboxSource.TextChanged += new System.EventHandler(this.tboxSource_TextChanged);
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
            this.btnEncode.Location = new System.Drawing.Point(518, 346);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnEncode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEncode.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEncode.OnHoverImage = null;
            this.btnEncode.OnPressedColor = System.Drawing.Color.Black;
            this.btnEncode.Radius = 5;
            this.btnEncode.Size = new System.Drawing.Size(106, 30);
            this.btnEncode.TabIndex = 38;
            this.btnEncode.Text = "Зашифровать -->";
            this.btnEncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
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
            this.btnDecode.Location = new System.Drawing.Point(518, 380);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnDecode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDecode.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDecode.OnHoverImage = null;
            this.btnDecode.OnPressedColor = System.Drawing.Color.Black;
            this.btnDecode.Radius = 5;
            this.btnDecode.Size = new System.Drawing.Size(106, 30);
            this.btnDecode.TabIndex = 39;
            this.btnDecode.Text = "<-- Расшифровать";
            this.btnDecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
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
            this.button1.Location = new System.Drawing.Point(628, 346);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.Black;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Radius = 5;
            this.button1.Size = new System.Drawing.Size(48, 64);
            this.button1.TabIndex = 40;
            this.button1.Text = "Menu";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioEng
            // 
            this.radioEng.BaseColor = System.Drawing.SystemColors.Control;
            this.radioEng.Checked = true;
            this.radioEng.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioEng.CheckedOnColor = System.Drawing.Color.Silver;
            this.radioEng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEng.FillColor = System.Drawing.Color.White;
            this.radioEng.Location = new System.Drawing.Point(539, 57);
            this.radioEng.Name = "radioEng";
            this.radioEng.Size = new System.Drawing.Size(54, 20);
            this.radioEng.TabIndex = 41;
            this.radioEng.Text = "ENG";
            this.radioEng.CheckedChanged += new System.EventHandler(this.radioEng_CheckedChanged);
            // 
            // radioRus
            // 
            this.radioRus.BaseColor = System.Drawing.SystemColors.Control;
            this.radioRus.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioRus.CheckedOnColor = System.Drawing.Color.Silver;
            this.radioRus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRus.FillColor = System.Drawing.Color.White;
            this.radioRus.Location = new System.Drawing.Point(599, 57);
            this.radioRus.Name = "radioRus";
            this.radioRus.Size = new System.Drawing.Size(54, 20);
            this.radioRus.TabIndex = 42;
            this.radioRus.Text = "RUS";
            this.radioRus.CheckedChanged += new System.EventHandler(this.radioRus_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.Location = new System.Drawing.Point(37, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 17);
            this.gunaLabel2.TabIndex = 43;
            this.gunaLabel2.Text = "Шифр Плейфера";
            this.gunaLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseDown);
            this.gunaLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseMove);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(246, -9);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(186, 38);
            this.gunaElipsePanel1.TabIndex = 44;
            this.gunaElipsePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseDown);
            this.gunaElipsePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseMove);
            // 
            // Playfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 422);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.radioRus);
            this.Controls.Add(this.radioEng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.tboxSource);
            this.Controls.Add(this.tboxDecoded);
            this.Controls.Add(this.tboxEncoded);
            this.Controls.Add(this.tboxBigramma);
            this.Controls.Add(this.tboxKeyword);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lvMatrix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(712, 431);
            this.Name = "Playfera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playfera_MouseMove);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvMatrix;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox tboxKeyword;
        private Guna.UI.WinForms.GunaTextBox tboxSource;
        private Guna.UI.WinForms.GunaTextBox tboxDecoded;
        private Guna.UI.WinForms.GunaTextBox tboxEncoded;
        private Guna.UI.WinForms.GunaTextBox tboxBigramma;
        private Guna.UI.WinForms.GunaButton button1;
        private Guna.UI.WinForms.GunaButton btnDecode;
        private Guna.UI.WinForms.GunaButton btnEncode;
        private Guna.UI.WinForms.GunaRadioButton radioRus;
        private Guna.UI.WinForms.GunaRadioButton radioEng;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}