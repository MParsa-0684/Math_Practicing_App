using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Practicing
{
    public partial class Form4 : Form
    {
        bool[] RadiobuttonLevel = new bool[8];
        int I = 1;
        int answer = 0;
        int[] Ten = new int[9];
        int M = 0;
        Random random = new Random();

        public Form4()
        {
            InitializeComponent();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[0] = true;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[1] = true;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[2] = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[3] = true;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[4] = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[5] = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[6] = true;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            M = 0;
            while (M < 8)
            {
                RadiobuttonLevel[M] = false;
                M++;
            }
            RadiobuttonLevel[7] = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            I = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            I = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            I = 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ten[0] = 1;
            Ten[1] = 10;
            Ten[2] = 100;
            Ten[3] = 1000;
            Ten[4] = 10000;
            Ten[5] = 100000;
            Ten[6] = 1000000;
            Ten[7] = 10000000;
            Ten[8] = 1000000000;

            int[] RadiobuttonNumber = new int[I];
            int counter = 0;
            if (RadiobuttonNumber.Length == 2)
            {
                while (counter < 8)
                {
                    if (RadiobuttonLevel[counter] == true)
                    {

                        RadiobuttonNumber[I - 2] = random.Next(Ten[counter], Ten[counter + 1]);
                        RadiobuttonNumber[I - 1] = random.Next(Ten[counter], Ten[counter + 1]);
                        string Sum = Convert.ToString(RadiobuttonNumber[I - 2]);
                        int SUM = RadiobuttonNumber[I - 2] - RadiobuttonNumber[I - 1];
                        string Plus = "-";
                        Lable3.Text = Plus;
                        string Sum2 = Convert.ToString(RadiobuttonNumber[I - 1]);
                        Lable2.Text = Sum2;
                        answer = SUM;
                        Lable1.Text = Sum;
                        Lable4.Text = "______________________________";

                        break;
                    }

                    counter++;

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "The answer is : " + Convert.ToString(answer);
            double Answer = Convert.ToDouble(textBox1.Text);
            if (Answer == answer)
            {
                label5.Text = "Your answer is correct . ";
                label5.ForeColor = Color.DarkGreen;
                label1.Text = Convert.ToString(Answer) + " is correct . ";
                label1.ForeColor = Color.DarkGreen;

            }
            if (Answer != answer)
            {
                label5.Text = "Your answer is incorrect . ";
                label5.ForeColor = Color.DarkRed;
                label1.Text = Convert.ToString(Answer) + " is incorrect . ";
                label1.ForeColor = Color.DarkRed;

            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    This Program developed by Mohammad Parsa Arani", "About");

        }
    }
}
