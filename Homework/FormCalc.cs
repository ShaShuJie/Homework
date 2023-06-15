using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormCal : Form
    {
        public FormCal()
        {
            InitializeComponent();
        }
        
        private void btnplus_Click(object sender, EventArgs e)
        {
            decimal num1, num2;

            if (decimal.TryParse(textNum1.Text, out num1) && decimal.TryParse(textNum2.Text, out num2))
            {
                decimal answer = num1 + num2;
                textAnswer.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            decimal num1, num2;

            if (decimal.TryParse(textNum1.Text, out num1) && decimal.TryParse(textNum2.Text, out num2))
            {
                decimal answer = num1 - num2;
                textAnswer.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal num1, num2;

            if (decimal.TryParse(textNum1.Text, out num1) && decimal.TryParse(textNum2.Text, out num2))
            {
                decimal answer = num1 * num2;
                textAnswer.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            if (decimal.TryParse(textNum1.Text, out num1) && decimal.TryParse(textNum2.Text, out num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("不能除以零");
                    return;
                }

                else
                {
                    decimal Answer = num1 / num2;
                    textAnswer.Text = Answer.ToString();
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void textNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // 忽略非數字和非小數點輸入
            }

            // 如果已經有一個小數點，則禁止再次輸入小數點
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true; // 忽略額外的小數點輸入
            }
        }

        private void textNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // 忽略非數字和非小數點輸入
            }

            // 如果已經有一個小數點，則禁止再次輸入小數點
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true; // 忽略額外的小數點輸入
            }
        }
    }
}
