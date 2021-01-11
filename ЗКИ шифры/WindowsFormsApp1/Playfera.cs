using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Playfera : Form
    {
        private int _matrixRows;
        private int _matrixCols;
        private char[,] _matrix;
        private const string EngAphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string RusAphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string _workAphabet;
        private IContainer components;

        public Playfera()
        {
            InitializeComponent();
            this._matrixRows = 5;
            this._matrixCols = 5;
            this._workAphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this._matrix = new char[this._matrixRows, this._matrixCols];
            this.lvMatrix.VirtualListSize = this._matrixRows;
            this.ClearMatrix();
        }

        private string PlayfairEncode(string keyword, string sourcetext)
        {
            this.FillMatrix(this.GetWorkKey(keyword));
            char oldChar = this.radioEng.Checked ? 'J' : 'Ё';
            char newChar = this.radioEng.Checked ? 'I' : 'Е';
            IEnumerable<string> bigramma1 = this.GetBigramma(sourcetext.ToUpper().Replace(oldChar, newChar));
            if (!(bigramma1 is string[] strArray))
                strArray = bigramma1.ToArray<string>();
            string[] strArray1 = strArray;
            this.tboxBigramma.Text = string.Join(" ", strArray1);
            List<string> stringList = new List<string>();
            foreach (string bigramma2 in strArray1)
            {
                string coded;
                if (this.BigrammaInOneRow(bigramma2, out coded))
                    stringList.Add(coded);
                else if (this.BigrammaInOneColumn(bigramma2, out coded))
                    stringList.Add(coded);
                else if (this.BigrammaInOthers(bigramma2, out coded))
                    stringList.Add(coded);
            }
            return string.Join("", (IEnumerable<string>)stringList);
        }

        private bool GetCoordinates(char symbol, out int foundRow, out int foundCol)
        {
            for (int index1 = 0; index1 < this._matrixRows; ++index1)
            {
                for (int index2 = 0; index2 < this._matrixCols; ++index2)
                {
                    if ((int)this._matrix[index1, index2] == (int)symbol)
                    {
                        foundRow = index1;
                        foundCol = index2;
                        return true;
                    }
                }
            }
            foundRow = -1;
            foundCol = -1;
            return false;
        }

        private bool BigrammaInOneRow(string bigramma, out string coded)
        {
            coded = "";
            int foundRow1;
            int foundCol1;
            int foundRow2;
            int foundCol2;
            if (!this.GetCoordinates(bigramma[0], out foundRow1, out foundCol1) || !this.GetCoordinates(bigramma[1], out foundRow2, out foundCol2) || foundRow1 != foundRow2)
                return false;
            coded = foundCol1 >= this._matrixCols - 1 ? coded + this._matrix[foundRow1, 0].ToString() : coded + this._matrix[foundRow1, foundCol1 + 1].ToString();
            coded = foundCol2 >= this._matrixCols - 1 ? coded + this._matrix[foundRow2, 0].ToString() : coded + this._matrix[foundRow2, foundCol2 + 1].ToString();
            return true;
        }

        private bool BigrammaInOneColumn(string bigramma, out string coded)
        {
            coded = "";
            int foundRow1;
            int foundCol1;
            int foundRow2;
            int foundCol2;
            if (!this.GetCoordinates(bigramma[0], out foundRow1, out foundCol1) || !this.GetCoordinates(bigramma[1], out foundRow2, out foundCol2) || foundCol1 != foundCol2)
                return false;
            coded = foundRow1 >= this._matrixRows - 1 ? coded + this._matrix[0, foundCol1].ToString() : coded + this._matrix[foundRow1 + 1, foundCol1].ToString();
            coded = foundRow2 >= this._matrixRows - 1 ? coded + this._matrix[0, foundCol2].ToString() : coded + this._matrix[foundRow2 + 1, foundCol2].ToString();
            return true;
        }

        private bool BigrammaInOthers(string bigramma, out string coded)
        {
            coded = "";
            int foundRow1;
            int foundCol1;
            int foundRow2;
            int foundCol2;
            if (!this.GetCoordinates(bigramma[0], out foundRow1, out foundCol1) || !this.GetCoordinates(bigramma[1], out foundRow2, out foundCol2) || (foundRow1 == foundRow2 || foundCol1 == foundCol2))
                return false;
            coded += this._matrix[foundRow1, foundCol2].ToString();
            coded += this._matrix[foundRow2, foundCol1].ToString();
            return true;
        }

        private IEnumerable<string> GetBigramma(string text)
        {
            List<char> charList = new List<char>();
            foreach (char c in text.Where<char>((Func<char, bool>)(symbol => this._workAphabet.IndexOf(char.ToUpper(symbol)) >= 0)))
                charList.Insert(0, char.ToUpper(c));
            Stack<char> charStack = new Stack<char>();
            foreach (char ch in charList)
                charStack.Push(ch);
            List<string> stringList = new List<string>();
            string str1 = "";
            char ch1 = this.radioEng.Checked ? 'X' : 'Я';
            while (charStack.Count > 0)
            {
                char ch2 = charStack.Pop();
                if (str1.Length < 2)
                {
                    if (str1.IndexOf(ch2) < 0)
                    {
                        str1 += ch2.ToString();
                    }
                    else
                    {
                        charStack.Push(ch2);
                        str1 += ch1.ToString();
                    }
                }
                if (str1.Length == 2)
                {
                    stringList.Add(str1);
                    str1 = "";
                }
            }
            if (str1.Length == 1)
            {
                string str2 = str1 + ch1.ToString();
                stringList.Add(str2);
            }
            return (IEnumerable<string>)stringList;
        }

        private string PlayfairDecode(string keyword, string sourcetext)
        {
            this.FillMatrix(this.GetWorkKey(keyword));
            IEnumerable<string> codedBigramma = this.GetCodedBigramma(sourcetext);
            if (!(codedBigramma is string[] strArray))
                strArray = codedBigramma.ToArray<string>();
            List<string> stringList = new List<string>();
            foreach (string bigramma in strArray)
            {
                string decoded;
                if (this.BigrammaFromOneRow(bigramma, out decoded))
                    stringList.Add(decoded);
                else if (this.BigrammaFromOneColumn(bigramma, out decoded))
                    stringList.Add(decoded);
                else if (this.BigrammaFromOthers(bigramma, out decoded))
                    stringList.Add(decoded);
            }
            return string.Join("", (IEnumerable<string>)stringList);
        }

        private bool BigrammaFromOneRow(string bigramma, out string decoded)
        {
            decoded = "";
            int foundRow1;
            int foundCol1;
            int foundRow2;
            int foundCol2;
            if (!this.GetCoordinates(bigramma[0], out foundRow1, out foundCol1) || !this.GetCoordinates(bigramma[1], out foundRow2, out foundCol2) || foundRow1 != foundRow2)
                return false;
            decoded = foundCol1 <= 0 ? decoded + this._matrix[foundRow1, this._matrixCols - 1].ToString() : decoded + this._matrix[foundRow1, foundCol1 - 1].ToString();
            decoded = foundCol2 <= 0 ? decoded + this._matrix[foundRow2, this._matrixCols - 1].ToString() : decoded + this._matrix[foundRow2, foundCol2 - 1].ToString();
            return true;
        }

        private bool BigrammaFromOneColumn(string bigramma, out string decoded)
        {
            decoded = "";
            int foundRow1;
            int foundCol1;
            int foundRow2;
            int foundCol2;
            if (!this.GetCoordinates(bigramma[0], out foundRow1, out foundCol1) || !this.GetCoordinates(bigramma[1], out foundRow2, out foundCol2) || foundCol1 != foundCol2)
                return false;
            decoded = foundRow1 <= 0 ? decoded + this._matrix[this._matrixRows - 1, foundCol1].ToString() : decoded + this._matrix[foundRow1 - 1, foundCol1].ToString();
            decoded = foundRow2 <= 0 ? decoded + this._matrix[this._matrixRows - 1, foundCol2].ToString() : decoded + this._matrix[foundRow2 - 1, foundCol2].ToString();
            return true;
        }

        private bool BigrammaFromOthers(string bigramma, out string decoded)
        {
            decoded = "";
            int foundRow1;
            int foundCol1;
            int foundRow2;
            int foundCol2;
            if (!this.GetCoordinates(bigramma[0], out foundRow1, out foundCol1) || !this.GetCoordinates(bigramma[1], out foundRow2, out foundCol2) || (foundRow1 == foundRow2 || foundCol1 == foundCol2))
                return false;
            decoded += this._matrix[foundRow1, foundCol2].ToString();
            decoded += this._matrix[foundRow2, foundCol1].ToString();
            return true;
        }

        private IEnumerable<string> GetCodedBigramma(string text)
        {
            List<char> charList = new List<char>();
            foreach (char c in text.Where<char>((Func<char, bool>)(symbol => this._workAphabet.IndexOf(char.ToUpper(symbol)) >= 0)))
                charList.Insert(0, char.ToUpper(c));
            Stack<char> charStack = new Stack<char>();
            foreach (char ch in charList)
                charStack.Push(ch);
            List<string> stringList = new List<string>();
            string str1 = "";
            while (charStack.Count > 0)
            {
                char ch = charStack.Pop();
                if (str1.Length < 2)
                    str1 += ch.ToString();
                if (str1.Length == 2)
                {
                    stringList.Add(str1);
                    str1 = "";
                }
            }
            if (str1.Length == 1)
            {
                char ch = this.radioEng.Checked ? 'X' : 'Я';
                string str2 = str1 + ch.ToString();
                stringList.Add(str2);
            }
            return (IEnumerable<string>)stringList;
        }

        private void FillMatrix(string workKey)
        {
            Queue<char> charQueue = new Queue<char>();
            foreach (char ch in workKey)
                charQueue.Enqueue(ch);
            char exsymb = this.radioEng.Checked ? 'J' : 'Ё';
            foreach (char ch in this._workAphabet.Where<char>((Func<char, bool>)(abc => workKey.IndexOf(abc) < 0 && (int)abc != (int)exsymb)))
                charQueue.Enqueue(ch);
            for (int index1 = 0; index1 < this._matrixRows; ++index1)
            {
                for (int index2 = 0; index2 < this._matrixCols; ++index2)
                    this._matrix[index1, index2] = charQueue.Dequeue();
            }
            this.lvMatrix.Invalidate();
        }

        private string GetWorkKey(string keyword)
        {
            StringBuilder result = new StringBuilder();
            char oldChar = this.radioEng.Checked ? 'J' : 'Ё';
            char newChar = this.radioEng.Checked ? 'I' : 'Е';
            foreach (char ch in keyword.ToUpper().Replace(oldChar, newChar).Where<char>((Func<char, bool>)(keyChar => keyChar != ' ')).Where<char>((Func<char, bool>)(keyChar => result.ToString().IndexOf(keyChar) < 0)))
                result.Append(ch);
            return result.ToString();
        }

        private void ClearMatrix()
        {
            for (int index1 = 0; index1 < this._matrixRows; ++index1)
            {
                for (int index2 = 0; index2 < this._matrixCols; ++index2)
                    this._matrix[index1, index2] = ' ';
            }
            this.lvMatrix.Invalidate();
        }

        private void lvMatrix_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-US");
            listViewItem.Text = this._matrix[e.ItemIndex, 0].ToString((IFormatProvider)cultureInfo);
            for (int index = 1; index < this._matrixCols; ++index)
                listViewItem.SubItems.Add(this._matrix[e.ItemIndex, index].ToString((IFormatProvider)cultureInfo));
            e.Item = listViewItem;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            this.tboxEncoded.Text = this.PlayfairEncode(this.tboxKeyword.Text, this.tboxSource.Text);
            this.tboxDecoded.Text = "";
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            this.tboxDecoded.Text = this.PlayfairDecode(this.tboxKeyword.Text, this.tboxEncoded.Text);
        }

        private void radioEng_CheckedChanged(object sender, EventArgs e)
        {
            lvMatrix.Size = new Size(150, 130);
            lvMatrix.Location = new Point(525, 131);
            this.lvMatrix.VirtualListSize = 0;
            this._matrixRows = 5;
            this._matrixCols = 5;
            this.lvMatrix.Columns.Clear();
            for (int index = 0; index < this._matrixCols; ++index)
                this.lvMatrix.Columns.Add(new ColumnHeader()
                {
                    Width = 30
                });
            this._workAphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this._matrix = new char[this._matrixRows, this._matrixCols];
            this.ClearMatrix();
            this.lvMatrix.VirtualListSize = this._matrixRows;
            this.tboxBigramma.Text = "";
            this.tboxEncoded.Text = "";
            this.tboxDecoded.Text = "";
            this.tboxKeyword.Text = "";
            this.tboxSource.Text = "";
        }

        private void radioRus_CheckedChanged(object sender, EventArgs e)
        {
            lvMatrix.Size = new Size(120, 208);
            lvMatrix.Location = new Point(540, 131);
            this.lvMatrix.VirtualListSize = 0;
            this._matrixRows = 8;
            this._matrixCols = 4;
            this.lvMatrix.Columns.Clear();
            for (int index = 0; index < this._matrixCols; ++index)
                this.lvMatrix.Columns.Add(new ColumnHeader()
                {
                    Width = 30
                });
            this._workAphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            this._matrix = new char[this._matrixRows, this._matrixCols];
            this.ClearMatrix();
            this.lvMatrix.VirtualListSize = this._matrixRows;
            this.tboxBigramma.Text = "";
            this.tboxEncoded.Text = "";
            this.tboxDecoded.Text = "";
            this.tboxKeyword.Text = "";
            this.tboxSource.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Playfera_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Playfera_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void tboxSource_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
