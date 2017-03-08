using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int starter = 0;
        int select;
        int[] arrayList = { 0,0,0,0,0,0,0,0};

        private void button1_Click(object sender, EventArgs e)
        {
            int input;

            if (starter == 8)
                starter = 0;

            if (userInput.Text != "9999")
            {
                input = Convert.ToInt32(userInput.Text);
                arrayList[starter] += input;
                userInput.Text = "";
                ++starter;
            }

            else
            {
                if (select == 1)
                {
                    outputLabel.Text = "Results";
                    for (int x = 0; x < arrayList.Length; ++x)
                    {
                        outputLabel.Text += String.Format("\n\nNumber {0} is:\t{1}", x + 1, arrayList[x].ToString());
                    }
                }
                else if (select == 2)
                {
                    outputLabel.Text = "Results";
                    for (int x = arrayList.Length-1; x >= 0 ; --x)
                    {
                        outputLabel.Text += String.Format("\n\nNumber {0} is:\t{1}", x + 1, arrayList[x].ToString());
                    }
                }
                else
                {
                    outputLabel.Text = "";
                    int y = Convert.ToInt32(comboBox1.Text);
                    outputLabel.Text = "Results";
                    outputLabel.Text += String.Format("\n\nNumber At {0} is {1}", comboBox1.Text, arrayList[y-1].ToString());
                }
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            select = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            select = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            select = 3;
        }
    }
}
