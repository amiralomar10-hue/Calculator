using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Calcualtor
{
    public partial class CalculatorForm : System.Windows.Forms.Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private double Factorial(double Number)
        {
            if (Number < 1)
            {
                return 1;
            }
            return Number * Factorial(Number - 1);
        }

        private double CalucaltorResult()
        {
            double result = 0;

            if (Oper.Text == bAdd.Text)
            {
                result = Double.Parse(Number.Text) + Double.Parse(Calc.Text);
            }
            else if (Oper.Text == bSub.Text)
            {

                result = Double.Parse(Number.Text) - Double.Parse(Calc.Text);
            }
            else if (Oper.Text == bMul.Text)
            {
                result = Double.Parse(Number.Text) * Double.Parse(Calc.Text);
            }
            else if (Oper.Text == bDiv.Text)
            {
                if (Calc.Text == "0")
                {
                    MessageBox.Show("You cannot be divided by 0 ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    result = Double.Parse(Number.Text) / Double.Parse(Calc.Text);

                }
            }
            else if (Oper.Text == bMod.Text)
            {
                if (Calc.Text == "0")
                {
                    MessageBox.Show("You cannot get the remainder of a division by 0 ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    result = Double.Parse(Number.Text) % Double.Parse(Calc.Text);

                }
            }

            else if (Oper.Text == buttonSquare.Text)
            {
                result = Math.Pow(Double.Parse(Number.Text), 2);
            }

            else if (Oper.Text == bPower.Text)
            {
                result = Math.Pow(Double.Parse(Number.Text), Double.Parse(Calc.Text));
            }

            else if (Oper.Text == bSqrt.Text)
            {
                result = Math.Sqrt(Double.Parse(Number.Text));
            }

            else if (Oper.Text == bFact.Text)
            {
                result = Factorial(Double.Parse(Number.Text));
            }

            else if (Oper.Text == buttonpow3.Text)
            {
                result = Math.Pow(Double.Parse(Number.Text), 3);
            }

            else if (Oper.Text == bInverted.Text)
            {
                result = Math.Pow(Double.Parse(Number.Text), -1);
            }

            else if (Oper.Text == buttonsqrtp3.Text)
            {
                result = Math.Pow(Double.Parse(Number.Text), 1.0 / 3.0);
            }
            else if (Oper.Text == b10powx.Text)
            {
                result = Double.Parse(Number.Text) * Math.Pow(10, Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonsin.Text)
            {
                result = Math.Sin(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonsin.Text)
            {
                result = Math.Sin(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttoncos.Text)
            {
                result = Math.Cos(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttontan.Text)
            {
                result = Math.Tan(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonAsin.Text)
            {
                result = Math.Asin(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttoncos.Text)
            {
                result = Math.Acos(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttontan.Text)
            {
                result = Math.Atan(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonlog.Text)
            {
                result = Math.Log10(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonln.Text)
            {
                result = Math.Log(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonRnd.Text)
            {
                result = Math.Round(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonCeil.Text)
            {
                result = Math.Ceiling(Double.Parse(Calc.Text));
            }

            else if (Oper.Text == buttonfloor.Text)
            {
                result = Math.Floor(Double.Parse(Calc.Text));
            }

            return result;
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calc.Text += button1.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Calc.Text = CalucaltorResult().ToString();
            Oper.Clear();
            Number.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calc.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calc.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calc.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calc.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calc.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calc.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calc.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calc.Text += button9.Text;
        }

        private void bfloat_Click(object sender, EventArgs e)
        {
            Calc.Text += bfloat.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Calc.Text += button0.Text;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonSquare.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "")
            {
                Calc.Text = Calc.Text.Substring(0, Calc.Text.Length - 1);
            }


        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bAdd.Text;
                if (Calc.Text == "")
                {
                    Number.Text = "0";
                }
                else
                    Number.Text = Calc.Text;
                Calc.Clear();
            }

        }

        private void bSub_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bSub.Text;
                if (Calc.Text == "")
                {
                    Number.Text = "0";
                }
                else
                    Number.Text = Calc.Text;

                Calc.Clear();
            }
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bMul.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bDiv.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bMod_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bMod.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Calc.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calc.Text = Math.PI.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calc.Text = Math.E.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bPower.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bSqrt.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void buttonpow3_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonpow3.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bInverted_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bInverted.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonsqrtp3_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonsqrtp3.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void b10powx_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = b10powx.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void bFact_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = bFact.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonsin_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonsin.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttontan_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttontan.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonlog.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonln_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonln.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonAsin_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonAsin.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonAtan_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonAtan.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonAcos_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonAcos.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttoncos_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttoncos.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonRnd_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonRnd.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonCeil_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonCeil.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void buttonfloor_Click(object sender, EventArgs e)
        {
            if (Oper.Text != "")
            {
                MessageBox.Show("You cannot enter two consecutive calculations.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Oper.Text = buttonfloor.Text;
                Number.Text = Calc.Text;
                Calc.Clear();
            }
        }

        private void Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
