using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_9
{
    public partial class Form1 : Form
    {
        Dictionary<char, int> outputDictionary = new Dictionary<char, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void input_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outputDictionary.Clear();
                string inputText = inputTextBox.Text;

                foreach (char c in inputText)
                {
                    if (outputDictionary.ContainsKey(Char.ToLower(c)))
                    {
                        outputDictionary[Char.ToLower(c)]++;
                    }
                    else
                    {
                        outputDictionary.Add(Char.ToLower(c), 1);
                    }
                }
                var maxValueKey = outputDictionary.OrderByDescending(x => x.Value).First().Key;
                output_label.Text = "Most frequent character is " + maxValueKey.ToString();
            }
            catch
            {
                output_label.Text = "Input is wrong";
            }

        }
    }
}
