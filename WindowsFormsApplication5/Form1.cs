using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int redBet = 0;
        int greenBet = 0;
        int blackBet = 0;
        int balance = 1000;
        int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            redBet += Int32.Parse(textBox1.Text);
            string redBet2 = redBet.ToString();
            label7.Text = redBet2;

            if (redBet > balance)
            {
                redBet = balance;
                string bal1 = balance.ToString();
                textBox1.Text = bal1;
                label7.Text = bal1;
            }

            balance -= redBet;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            greenBet += Int32.Parse(textBox2.Text);
            string greenBet2 = greenBet.ToString();
            label8.Text = greenBet2;

            if (greenBet > balance)
            {
                greenBet = balance;
                string bal1 = balance.ToString();
                textBox2.Text = bal1;
                label8.Text = bal1;
            }

            balance -= greenBet;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            blackBet += Int32.Parse(textBox3.Text);
            string blackBet2 = blackBet.ToString();
            label9.Text = blackBet2;

            if (blackBet > balance)
            {
                blackBet = balance;
                string bal1 = balance.ToString();
                textBox3.Text = bal1;
                label9.Text = bal1;
            }

            balance -= blackBet;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "0";
            balance += redBet;
            redBet = 0;
            button1.Enabled = true;

            label8.Text = "0";
            balance += greenBet;
            greenBet = 0;
            button3.Enabled = true;

            label9.Text = "0";
            balance += blackBet;
            blackBet = 0;
            button2.Enabled = true;
        }

        private void Reset_Tick(object sender, EventArgs e)
        {
            string balance1 = balance.ToString();
            label11.Text = balance1;
        }

        int all = 30;
        int lg0 = 12;
        int lr1 = 112;
        int lb2 = 212;
        int lr3 = 312;
        int lb4 = 412;
        int lr5 = 512;
        int lb6 = 612;
        int lr7 = 712;
        int lb8 = 812;
        int lr9 = 912;
        int lb10 = 1012;

        private async void roll1_Tick(object sender, EventArgs e)
        {
            if (count == 1)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 25;
                lr1 -= 25;
                lb2 -= 25;
                lr3 -= 25;
                lb4 -= 25;
                lr5 -= 25;
                lb6 -= 25;
                lr7 -= 25;
                lb8 -= 25;
                lr9 -= 25;
                lb10 -= 25;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                    count += 1;
                }
            }

            if (count == 2)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 22;
                lr1 -= 22;
                lb2 -= 22;
                lr3 -= 22;
                lb4 -= 22;
                lr5 -= 22;
                lb6 -= 22;
                lr7 -= 22;
                lb8 -= 22;
                lr9 -= 22;
                lb10 -= 22;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                    count += 1;
                }
            }

            if (count == 3)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 19;
                lr1 -= 19;
                lb2 -= 19;
                lr3 -= 19;
                lb4 -= 19;
                lr5 -= 19;
                lb6 -= 19;
                lr7 -= 19;
                lb8 -= 19;
                lr9 -= 19;
                lb10 -= 19;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                    count += 1;
                }
            }

            if (count == 4)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 16;
                lr1 -= 16;
                lb2 -= 16;
                lr3 -= 16;
                lb4 -= 16;
                lr5 -= 16;
                lb6 -= 16;
                lr7 -= 16;
                lb8 -= 16;
                lr9 -= 16;
                lb10 -= 16;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                    count += 1;
                }
            }

            if (count == 5)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 13;
                lr1 -= 13;
                lb2 -= 13;
                lr3 -= 13;
                lb4 -= 13;
                lr5 -= 13;
                lb6 -= 13;
                lr7 -= 13;
                lb8 -= 13;
                lr9 -= 13;
                lb10 -= 13;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                    count += 1;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                }
            }

            if (count == 6)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 10;
                lr1 -= 10;
                lb2 -= 10;
                lr3 -= 10;
                lb4 -= 10;
                lr5 -= 10;
                lb6 -= 10;
                lr7 -= 10;
                lb8 -= 10;
                lr9 -= 10;
                lb10 -= 10;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                    count += 1;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                }
            }

            if (count == 7)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 7;
                lr1 -= 7;
                lb2 -= 7;
                lr3 -= 7;
                lb4 -= 7;
                lr5 -= 7;
                lb6 -= 7;
                lr7 -= 7;
                lb8 -= 7;
                lr9 -= 7;
                lb10 -= 7;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                    count += 1;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                }
            }

            if (count == 8)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                lg0 -= 8;
                lr1 -= 8;
                lb2 -= 8;
                lr3 -= 8;
                lb4 -= 8;
                lr5 -= 8;
                lb6 -= 8;
                lr7 -= 8;
                lb8 -= 8;
                lr9 -= 8;
                lb10 -= 8;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;
                    count += 1;
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;
                }
            }

            if (count == 9)
            {
                g0.Location = new Point(lg0, all);
                r1.Location = new Point(lr1, all);
                b2.Location = new Point(lb2, all);
                r3.Location = new Point(lr3, all);
                b4.Location = new Point(lb4, all);
                r5.Location = new Point(lr5, all);
                b6.Location = new Point(lb6, all);
                r7.Location = new Point(lr7, all);
                b8.Location = new Point(lb8, all);
                r9.Location = new Point(lr9, all);
                b10.Location = new Point(lb10, all);

                Random random = new Random();
                int random1 = random.Next(1, 12);

                lg0 -= 7;
                lr1 -= 7;
                lb2 -= 7;
                lr3 -= 7;
                lb4 -= 7;
                lr5 -= 7;
                lb6 -= 7;
                lr7 -= 7;
                lb8 -= 7;
                lr9 -= 7;
                lb10 -= 7;

                if (g0.Location.X <= -89)
                {
                    lg0 = lb10 + 100;

                    if (random1 == 1)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label9.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label9.Text = payout3;
                        label9.ForeColor = Color.ForestGreen;
                        label8.ForeColor = Color.DarkRed;
                        label7.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (r1.Location.X <= -89)
                {
                    lr1 = lg0 + 100;

                    if (random1 == 2)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label7.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label7.Text = payout3;
                        label7.ForeColor = Color.ForestGreen;
                        label9.ForeColor = Color.DarkRed;
                        label8.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (b2.Location.X <= -89)
                {
                    lb2 = lr1 + 100;

                    if (random1 == 3)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label9.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label9.Text = payout3;
                        label9.ForeColor = Color.ForestGreen;
                        label8.ForeColor = Color.DarkRed;
                        label7.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (r3.Location.X <= -89)
                {
                    lr3 = lb2 + 100;

                    if (random1 == 4)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label7.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label7.Text = payout3;
                        label7.ForeColor = Color.ForestGreen;
                        label9.ForeColor = Color.DarkRed;
                        label8.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (b4.Location.X <= -89)
                {
                    lb4 = lr3 + 100;

                    if (random1 == 5)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label9.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label9.Text = payout3;
                        label9.ForeColor = Color.ForestGreen;
                        label8.ForeColor = Color.DarkRed;
                        label7.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (r5.Location.X <= -89)
                {
                    lr5 = lb4 + 100;

                    if (random1 == 6)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label7.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label7.Text = payout3;
                        label7.ForeColor = Color.ForestGreen;
                        label9.ForeColor = Color.DarkRed;
                        label8.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (b6.Location.X <= -89)
                {
                    lb6 = lr5 + 100;

                    if (random1 == 7)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label9.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label9.Text = payout3;
                        label9.ForeColor = Color.ForestGreen;
                        label8.ForeColor = Color.DarkRed;
                        label7.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (r7.Location.X <= -89)
                {
                    lr7 = lb6 + 100;

                    if (random1 == 8)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label8.Text);
                        int payout2 = payout1 * 10;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label8.Text = payout3;
                        label8.ForeColor = Color.ForestGreen;
                        label9.ForeColor = Color.DarkRed;
                        label7.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (b8.Location.X <= -89)
                {
                    lb8 = lr7 + 100;

                    if (random1 == 9)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label7.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label7.Text = payout3;
                        label7.ForeColor = Color.ForestGreen;
                        label9.ForeColor = Color.DarkRed;
                        label8.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (r9.Location.X <= -89)
                {
                    lr9 = lb8 + 100;

                    if (random1 == 10)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label9.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label9.Text = payout3;
                        label9.ForeColor = Color.ForestGreen;
                        label8.ForeColor = Color.DarkRed;
                        label7.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }

                if (b10.Location.X <= -89)
                {
                    lb10 = lr9 + 100;

                    if (random1 == 11)
                    {
                        count += 1;
                        int payout1 = Int32.Parse(label7.Text);
                        int payout2 = payout1 * 2;
                        balance += payout2;
                        string payout3 = payout2.ToString();
                        label7.Text = payout3;
                        label7.ForeColor = Color.ForestGreen;
                        label9.ForeColor = Color.DarkRed;
                        label8.ForeColor = Color.DarkRed;
                        count = 0;
                        await Task.Delay(3000);
                        button4.Enabled = true;
                        redBet = 0;
                        blackBet = 0;
                        greenBet = 0;
                        label7.ForeColor = Color.White;
                        label8.ForeColor = Color.White;
                        label9.ForeColor = Color.White;
                        label7.Text = "0";
                        label8.Text = "0";
                        label9.Text = "0";
                        roll1.Stop();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        button5.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            count = 1;

            button4.Enabled = false;
            button5.Enabled = false;

            textBox1.Text = "";
            textBox1.Enabled = false;

            textBox2.Text = "";
            textBox2.Enabled = false;

            textBox3.Text = "";
            textBox3.Enabled = false;
            
            roll1.Start();
        }
    }
}
