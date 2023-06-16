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
    public partial class FormHello : Form
    {
        public FormHello()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // 設置窗口邊框樣式為固定的單個邊框
            this.Size = new Size(800, 600);
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string gender = textGender.Text.Trim();
            decimal Age;
            if (gender == "男" || gender == "女")
            {
                if (decimal.TryParse(textAge.Text, out Age))
                
                MessageBox.Show("姓名: " + textName.Text + "\n性別: " + gender + "\n年齡: " + Age + "\n成功加入");
                else
                {
                    MessageBox.Show("請輸入有效的年齡");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的性別（男或女）");
            }
        }
    }
}
