using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxVal = 0;
            int vowCount = 0;
            int maxVowels = 0;
            int longWord = 0;
            string str;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                str = System.IO.File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = str.ToLower();
                string[] array = str.Split(' ');
                textBox2.Text = array[0];
                textBox3.Text = array[array.Length - 1];

                for (int i = 0; i < array.Length; i++)
                {

                    if (maxVal < array[i].Length)
                    {
                        maxVal = array[i].Length;
                        longWord = i;
                    }

                    if (vowCount < VowelCount(array[i]))
                    {
                        vowCount = VowelCount(array[i]);
                        maxVowels = i;
                    }
                }

                textBox4.Text = array[longWord];
                textBox5.Text = array[maxVowels];
    
                MessageBox.Show("text file is created");

            }
        }

        public int VowelCount(string sentence)
        {
            int vowels = 0;

            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u'))
                {
                    vowels = vowels + 1;
                }
            }
            return vowels;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
