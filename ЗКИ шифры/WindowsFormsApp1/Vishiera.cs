using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Vishiera : Form
    {
        private const string EngAphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string RusAphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string workAphabet;
        int index;

        public Vishiera()
        {
            InitializeComponent();
            workAphabet = EngAphabet;
            index = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            var inputText = tboxSource.Text.ToUpper();
            var password = tboxKeyword.Text.ToUpper();
            if (password != "")
            {
                var encryptedText = Encrypt(inputText, password);
                tboxEncoded.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("Введите Key");
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var inputText = tboxEncoded.Text.ToUpper();
            var password = tboxKeyword.Text.ToUpper();
            if (password != "")
            {
                tboxDecoded.Text = Decrypt(inputText, password);
            }
            else
            {
                MessageBox.Show("Введите Key");
            }
        }

        string SortText;
        string SortPass;
        private string GetRepeatKey(string password, string text)
        {
            int j = 0;
            SortText = "";
            SortPass = "";
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLetter(password[i]))
                {
                    SortPass += password[i].ToString();
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    SortText += SortPass[j].ToString();
                    j++;
                }
                else
                {
                    SortText += ' ';
                }

                if (j > SortPass.Length - 1)
                {
                    j = 0;
                }
            }

            return SortText.Substring(0, text.Length);
        }

        private string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text);
            var retValue = "";
            var q = workAphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = workAphabet.IndexOf(text[i]);
                var codeIndex = workAphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += workAphabet[(q + letterIndex + index + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }
            return retValue;
        }


        private string Vigenere1(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text);
            var retValue = "";
            var q = workAphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = workAphabet.IndexOf(text[i]);
                var codeIndex = workAphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += workAphabet[(q + letterIndex - 1 + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }
            return retValue;
        }

        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);

        public string Decrypt1(string encryptedMessage, string password)
            => Vigenere1(encryptedMessage, password, false);

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioEng_CheckedChanged(object sender, EventArgs e)
        {
            workAphabet = EngAphabet;
        }

        private void radioRus_CheckedChanged(object sender, EventArgs e)
        {
            workAphabet = RusAphabet;
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            index = 0;
            btnDecode.Visible = true;
            gunaButton1.Visible = false;
            btnDecode.Location = new Point(519, 371);
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            index = 1;
            gunaButton1.Visible = true;
            btnDecode.Visible = false;
            gunaButton1.Location = new Point(519, 371);
        }

        Point lastPoint;
        private void Vishiera_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Vishiera_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var inputText = tboxEncoded.Text.ToUpper();
            var password = tboxKeyword.Text.ToUpper();
            if (password != "")
            {
                tboxDecoded.Text = Decrypt1(inputText, password);
            }
            else
            {
                MessageBox.Show("Введите Key");
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Table table = new Table();

            if (radioEng.Checked == true && gunaRadioButton2.Checked == true)
                table.gunaPictureBox1.Image = Properties.Resources.vizhenerEngAAA1;
            if (radioRus.Checked == true && gunaRadioButton2.Checked == true)
                table.gunaPictureBox1.Image = Properties.Resources.vizhenerRusAAA1;
            if (radioEng.Checked == true && gunaRadioButton1.Checked == true)
                table.gunaPictureBox1.Image = Properties.Resources.vizhenerEngAAB;
            if (radioRus.Checked == true && gunaRadioButton1.Checked == true)
                table.gunaPictureBox1.Image = Properties.Resources.vizhenerRusAAБ;

            table.Show();
        }

        private void Vishiera_Load(object sender, EventArgs e)
        {

        }
    }
}