using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGenerator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintProductVersion()
        {
            this.Text = "Build: " +
               Application.ProductVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Pass generator (by 3eLLenKa)";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.textBox1.ReadOnly = true;

            PrintProductVersion();
        }

        private bool check_symbols(char symbols)
        {
            if (symbols == '/' || symbols == '\\' ||
                        symbols == '(' || symbols == ')' ||
                        symbols == '{' || symbols == '}' ||
                        symbols == '.' || symbols == ',' ||
                        symbols == '\'' || symbols == ':')
            {
                return true;
            }
            else return false;
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            string digits;
            char symbols;
            int size = Convert.ToInt32(numericUpDown1.Text);
            bool check = checkBox1.Checked;

            Random rnd = new Random();

            textBox1.Text = "";

            if (check == true)
            {
                for (int i = 0; i < size; i++)
                {
                    symbols = Convert.ToChar(rnd.Next(33, 128));

                    if (check_symbols(symbols))
                    {
                        continue;
                    }
                    
                    textBox1.Text += symbols;
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    digits = rnd.Next(0, 9).ToString();
                    textBox1.Text += digits;
                }
            }
        }
    }
}
