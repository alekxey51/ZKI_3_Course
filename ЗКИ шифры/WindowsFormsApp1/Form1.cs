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
    public partial class Form1 : Form
    {
        string RU = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string ENG = "abcdefghijklmnopqrstuvwxyz";
        string languages = "";
        string SortOffer = "";

        //Лучше сразу умереть, нежели жить ожиданием смерти. Гай Юлий Цезарь.

        public Form1()
        {
            InitializeComponent();
            languages = RU;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                textBox6.Text = "";
                SortOffer = "";

                Check();
                if (checkBox1.Checked == true)
                    Shifr();
                else if (checkBox2.Checked == true)
                    Shifr2();
                else if (checkBox5.Checked == true)
                    Preobrazovanie();
                else
                    MessageBox.Show("Выберите формулу");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            languages = RU;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            languages = ENG;
        }

        private void Check()
        {
            for (int i = 0; i < textBox4.Text.Length; i++)
            {
                if (Char.IsLetterOrDigit(textBox4.Text[i]))
                {
                    SortOffer += textBox4.Text[i].ToString().ToLower();
                }
            }
            SortOffer = " " + SortOffer;
        }

        private void Shifr()
        {
            for (int i = 1; i < SortOffer.Length; i++)
            {
                for (int j = 0; j < languages.Length; j++)
                {
                    if (SortOffer[i] == languages[j])
                    {
                        int k = Convert.ToInt32(textBox1.Text) * i + 1;
                        int index = (j + k) % languages.Length;
                        textBox6.Text += languages[index];

                        string s3 = SortOffer[i] + $"({i})={textBox1.Text}*{i}+1={k}({languages[index]})";

                        listView1.Items.Add(s3);
                        break;
                    }
                }
            }
        }

        private void Shifr2()
        {
            for (int i = 1; i < SortOffer.Length; i++)
            {
                for (int j = 0; j < languages.Length; j++)
                {
                    if (SortOffer[i] == languages[j])
                    {
                        double a = Convert.ToInt32(textBox2.Text) * Math.Pow(i, 2);
                        int b = Convert.ToInt32(textBox3.Text) * i;
                        double k = a + b - 7;
                        int index = (j + (int)k) % languages.Length;

                        textBox6.Text += languages[index];

                        string s3 = SortOffer[i] + $"({i})={a}^2+{b}-7={k}({languages[index]})";

                        listView1.Items.Add(s3);
                        break;
                    }
                }
            }
        }

        // 250+250
        private void Preobrazovanie()
        {
            string s = textBox5.Text.ToString() + " ";
            string r = "";
            int j = 0;
            while (Char.IsDigit(s[j]))
            {
                r += s[j];
                j++;
            }
            double k = Convert.ToInt32(r);
            string r1 = "";
            for (int i = j + 1; i < s.Length; i++)
            {
                if (s[i] == '+')
                {
                    i++;
                    while (Char.IsDigit(s[i]))
                    {
                        r1 += s[i];
                        i++;
                    }
                    k += Convert.ToInt32(r1);
                    r1 = "";
                }
                else if (s[i] == '-')
                {
                    i++;
                    while (Char.IsDigit(s[i]))
                    {
                        r1 += s[i];
                        i++;
                    }
                    k -= Convert.ToInt32(r1);
                    r1 = "";
                }
                if (s[i] == '^')
                {
                    i++;
                    while (Char.IsDigit(s[i]))
                    {

                        r1 += s[i];
                        i++;
                    }
                    int y = Convert.ToInt32(r1);
                    k = Math.Pow(k, y);
                    r1 = "";
                }
                if (s[i] == '/')
                {
                    i++;
                    while (Char.IsDigit(s[i]))
                    {

                        r1 += s[i];
                        i++;
                    }
                    k /= Convert.ToInt32(r1);
                    r1 = "";
                }
                listView1.Items.Add(i.ToString());
            }
            MessageBox.Show(k.ToString());
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form2 = new Menu();
            form2.Show();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
