using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{

    public partial class Form1 : Form
    {
        private double _num1 = 0, _num2 = 0, _result = 0;
        private string _operator = "";
        private int _operatorCount = 0;
        private int _clearFlag = 0;
        private int a10 = 1, a2 = 0, a8 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "1".ToString();
            }
            else
            {
                textBox1.Text = "1";
                _clearFlag =0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "2".ToString();
            }
            else
            {
                textBox1.Text = "2";
                _clearFlag =0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "6".ToString();
            }
            else
            {
                textBox1.Text = "6";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num3_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "3".ToString();
            }
            else
            {
                textBox1.Text = "3";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num4_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "4".ToString();
            }
            else
            {
                textBox1.Text = "4";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num5_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "5".ToString();
            }
            else
            {
                textBox1.Text = "5";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num7_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "7".ToString();
                
            }
            else
            {
                textBox1.Text = "7";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num8_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "8".ToString();
            }
            else
            {
                textBox1.Text = "8";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num9_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "9".ToString();
            }
            else
            {
                textBox1.Text = "9";
                _clearFlag = 0;
            }

            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1num0_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_clearFlag == 0)
            {
                textBox1.Text = textBox1.Text + "0".ToString();
            }
            else
            {
                textBox1.Text = "0";
                _clearFlag = 0;
            }
            _clearFlag = 1;
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1add_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (_operatorCount == 0)
            {
                if (a10 == 1 && a8 == 0 && a2 == 0)
                    _num1 = Convert.ToInt32(textBox1.Text);
                if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 2);
                }
                if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 8);
                }
                _operator = "+";
                textBox1.Text = "";
                _operatorCount = 1;
                
            }
               
            else
            {
                
                if (a10 == 1 && a8 == 0 && a2 == 0)
                   _num2 = Convert.ToDouble(textBox1.Text);
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 2);
                }
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 8);
                }
                if (_operator == "+") _num1 = _num1 + _num2;
                else if (_operator == "-") _num1 = _num1 - _num2;
                else if (_operator == "*") _num1 = _num1 * _num2;
                else if (_operator == "/") _num1 = _num1 / _num2;
                _operator = "+";

                int num;
                string str;
                str = _num1.ToString();
                num = Convert.ToInt32(str);
                if (a10 == 1 && a8 == 0 && a2 == 0)
                    textBox1.Text = _num1.ToString();
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                    textBox1.Text = Convert.ToString(num, 2);
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                    textBox1.Text = Convert.ToString(num, 8);
            }
            _clearFlag = 1;
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1subtract_Click(object sender, EventArgs e)
        {
            
            textBox1.Focus();
            if (_operatorCount == 0)
            {
                if (a10 == 1 && a8 == 0 && a2 == 0) _num1 = Convert.ToDouble(textBox1.Text);
                if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 2);
                }
                if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 8);
                }
               
                _operator = "-";
                textBox1.Text = "";
                _operatorCount = 1;
            }
            else
            {
                if (a10 == 1 && a8 == 0 && a2 == 0) _num2 = Convert.ToDouble(textBox1.Text);
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 2);
                }
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 8);
                }
                if (_operator == "+") _num1 = _num1 + _num2;
                else if (_operator == "-") _num1 = _num1 - _num2;
                else if (_operator == "*") _num1 = _num1 * _num2;
                else if (_operator == "/") _num1 = _num1 / _num2;
                _operator = "-";
                
                int num;
                string str;
                str = _num1.ToString();
                num = Convert.ToInt32(str);
                if (a10 == 1 && a8 == 0 && a2 == 0) textBox1.Text = _num1.ToString();
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                    textBox1.Text = Convert.ToString(num, 2);
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                    textBox1.Text = Convert.ToString(num, 8);
            }
            _clearFlag = 1;
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1multiply_Click(object sender, EventArgs e)
        {
            
            if (_operatorCount == 0)
            {
                if (a10 == 1 && a8 == 0 && a2 == 0) _num1 = Convert.ToDouble(textBox1.Text);
                if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 2);
                }
                if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 8);
                }
                _operator = "*";
                textBox1.Text = "";
                _operatorCount = 1;
            }
            else
            {
                if (a10 == 1 && a8 == 0 && a2 == 0) _num2 = Convert.ToDouble(textBox1.Text);
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 2);
                }
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 8);
                }
                if (_operator == "+") _num1 = _num1 + _num2;
                else if (_operator == "-") _num1 = _num1 - _num2;
                else if (_operator == "*") _num1 = _num1 * _num2;
                else if (_operator == "/") _num1 = _num1 / _num2;
                _operator = "*";
               
                int num;
                string str;
                str = _num1.ToString();
                num = Convert.ToInt32(str);
                if (a10 == 1 && a8 == 0 && a2 == 0) textBox1.Text = _num1.ToString();
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                    textBox1.Text = Convert.ToString(num, 2);
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                    textBox1.Text = Convert.ToString(num, 8);
            }
            _clearFlag = 1;
            textBox1.Focus();
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1division_Click(object sender, EventArgs e)
        {
            
            textBox1.Focus();
            if (_operatorCount == 0)
            {
                if (a10 == 1 && a8 == 0 && a2 == 0) _num1 = Convert.ToDouble(textBox1.Text);
                if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 2);
                }
                if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num1 = Convert.ToInt32(textBox1.Text, 8);
                }
                _operator = "/";
                textBox1.Text = "";
                _operatorCount = 1;
            }
            else
            {
                if (a10 == 1 && a8 == 0 && a2 == 0) _num2 = Convert.ToDouble(textBox1.Text);
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 2);
                }
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                {
                    _num2 = Convert.ToInt32(textBox1.Text, 8);
                }
                if (_operator == "+") _num1 = _num1 + _num2;
                else if (_operator == "-") _num1 = _num1 - _num2;
                else if (_operator == "*") _num1 = _num1 * _num2;
                else if (_operator == "/") _num1 = _num1 / _num2;
                _operator = "/";
                int num;
                string str;
                str = _num1.ToString();
                num = Convert.ToInt32(str);
                if (a10 == 1 && a8 == 0 && a2 == 0) textBox1.Text = _num1.ToString();
                else if (a10 == 0 && a8 == 0 && a2 == 1)
                    textBox1.Text = Convert.ToString(num, 2);
                else if (a10 == 0 && a8 == 1 && a2 == 0)
                    textBox1.Text = Convert.ToString(num, 8);
            }
            _clearFlag = 1;
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1equal_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (a10 == 1 && a8 == 0 && a2 == 0) _num2 = Convert.ToDouble(textBox1.Text);
            else if (a10 == 0 && a8 == 0 && a2 == 1)
            {
                _num2 = Convert.ToInt32(textBox1.Text, 2);
            }
            else if (a10 == 0 && a8 == 1 && a2 == 0)
            {
                _num2 = Convert.ToInt32(textBox1.Text, 8);
            }
            if (_operator == "+") _result = _num1 + _num2;
            else if (_operator == "-") _result = _num1 - _num2;
            else if (_operator == "*") _result = _num1 * _num2;
            else if (_operator == "/") _result = _num1 / _num2;
            string str;
            int num;
            str = _result.ToString();
            if (a10 == 1 && a8 == 0 && a2 == 0) textBox1.Text =_result.ToString();
            else if (a10 == 0 && a8 == 0 && a2 == 1)
            {
                num = Convert.ToInt32(str);
                textBox1.Text = Convert.ToString(num, 2);
            }
            else if (a10 == 0 && a8 == 1 && a2 == 0)
            {
                num = Convert.ToInt32(str);
                textBox1.Text = Convert.ToString(num, 8);
            }
            textBox1.Select(textBox1.Text.Length, 1);
                
        }
        private void button1clear_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            _num1 = _num2 = _result = 0;
            _operator = "";
            _clearFlag = 0;
            _operatorCount = 0;
            textBox1.Text = "";
            ;
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                button1num0.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '1')
            {
                button1num1.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '2')
            {
                button1num2.PerformClick();//键盘响应按钮功能
                e.Handled = true;
            }
            else if (e.KeyChar == '3')
            {
                button1num3.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '4')
            {
                button1num4.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '5')
            {
                button1num5.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '6')
            {
                button1num6.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '7')
            {
                button1num7.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '8')
            {
                button1num8.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '9')
            {
                button1num9.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                button1point.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '+')
            {
                button1add.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                button1subtract.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '*')
            {
                button1multiply.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '/')
            {
                button1division.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '=')
            {
                button1equal.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == 'C')
            {
                button1clear.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == '\b')
            {
                button1backspace.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                button1equal.PerformClick();
                e.Handled = true;
            }
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void button1sign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                string _firstChar = textBox1.Text.Substring(0, 1);
                if (_firstChar == "-")
                    textBox1.Text = "+" + textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                else if (_firstChar == "+")
                    textBox1.Text = "-" + textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                else
                    textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button1backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)//如果不判断，就会有bug;
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void radioButton2eight_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (textBox1.Text.Length != 0 && a10 == 1 && a8 == 0 && a2 == 0)
            {
                
                num = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(num, 8);
            }
            else if (textBox1.Text.Length != 0 && a10 == 0 && a8 == 1 && a2 == 0)
            {
                num = Convert.ToInt32(textBox1.Text, 2);
                textBox1.Text = Convert.ToString(num, 8);
            }
            else if (textBox1.Text.Length != 0 && a10 == 0 && a8 == 0 && a2 == 1)
                textBox1.Text = textBox1.Text;
            button1num2.Enabled = true;
            button1num3.Enabled = true;
            button1num4.Enabled = true;
            button1num5.Enabled = true;
            button1num6.Enabled = true;
            button1num7.Enabled = true;
            button1num8.Enabled = false;
            button1num9.Enabled = false;
            radioButton1.Checked = false;
            a10 = 0;
            radioButton2eight.Checked = true;
            a8 = 1;
            radioButton2two.Checked = false;
            a2 = 0;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            int num = 0;
             if (textBox1.Text.Length != 0&&a10 == 0 && a8 == 0 && a2 == 1)
            {
                num = Convert.ToInt32(textBox1.Text, 2);
                textBox1.Text = num.ToString();
            }
            else if (textBox1.Text.Length != 0&&a10 == 0 && a8 == 1 && a2 == 0)
            {
                num = Convert.ToInt32(textBox1.Text, 8);
                textBox1.Text = num.ToString();
            }
             else if (textBox1.Text.Length != 0 && a10 == 1 && a8 == 0 && a2 == 0)
             {
                 textBox1.Text = textBox1.Text;
                 textBox1.Text = num.ToString();
             }
            button1num2.Enabled = true;
            button1num3.Enabled = true;
            button1num4.Enabled = true;
            button1num5.Enabled = true;
            button1num6.Enabled = true;
            button1num7.Enabled = true;
            button1num8.Enabled = true;
            button1num9.Enabled = true;
            radioButton1.Checked = true;
            a10 = 1;
            radioButton2eight.Checked = false;
            a8 = 0;
            radioButton2two.Checked =false;
            a2 = 0;
        }

        private void radioButton2two_Click_1(object sender, EventArgs e)
        {
            int num = 0;
            if (textBox1.Text.Length != 0 && a10 == 1 && a8 == 0 && a2 == 0)
            {
                
                num = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(num, 2);
            }
            else if (textBox1.Text.Length != 0 && a10 == 0 && a8 == 1 && a2 == 0)
            {
                num = Convert.ToInt32(textBox1.Text, 8);
                textBox1.Text = Convert.ToString(num, 2);
            }
            else if (textBox1.Text.Length != 0 && a10 == 0 && a8 == 0 && a2 == 1)
                textBox1.Text = textBox1.Text;
            button1num2.Enabled = false;
            button1num3.Enabled = false;
            button1num4.Enabled = false;
            button1num5.Enabled = false;
            button1num6.Enabled = false;
            button1num7.Enabled = false;
            button1num8.Enabled = false;
            button1num9.Enabled = false;
            radioButton1.Checked = false;
            a10 = 0;
            radioButton2eight.Checked = false;
            a8 = 0;
            radioButton2two.Checked = true;
            a2 = 1;
        }

        private void button1point_Click_1(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (textBox1.Text.IndexOf('.')==-1) textBox1.Text = textBox1.Text + ".".ToString();
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        }


   
}