using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.Utility;

namespace Homework
{
    public partial class FormLoan : Form
    {
        public FormLoan()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // 設置窗口邊框樣式為固定的單個邊框
            this.Size = new Size(750, 500);
        }

        private bool boolMessageDisplayed = true;
        public decimal LoanYear, LoanMonth, YLoanRate, MLoanRate, DownPayment, LoanAmount, MonthPayment, TotalPaymentResult;

        public void pay()
        {
            if (decimal.TryParse(textLoanYear.Text, out LoanYear))
            {
                LoanMonth = decimal.Parse(textLoanYear.Text) * 12;
            }

            if (decimal.TryParse(textLoanRate.Text, out YLoanRate))
            {
                MLoanRate = decimal.Parse(textLoanRate.Text) / 1200;
            }

            if (decimal.TryParse(textLoanAmount.Text, out LoanAmount))
            { }

            if (decimal.TryParse(textDownPayment.Text, out DownPayment))
            { }

            if (LoanYear != 0 && LoanMonth != 0 && YLoanRate != 0 && MLoanRate != 0 && (DownPayment >= 0 ) && LoanAmount > 0)
            {
                if(LoanYear<1 || LoanAmount<1000 || YLoanRate<1)
                {
                    MessageBox.Show("貸款金額請輸入1千(含)以上，貸款年限請輸入1年(含)以上，貸款利率請輸入1%(含)以上");
                    boolMessageDisplayed = false;
                }
                else
                {
                MonthPayment = Math.Round(MLoanRate * (LoanAmount - DownPayment) / (1 - (decimal)Math.Pow(1 + (double)MLoanRate, (double)LoanMonth * -1)), 0);
                TotalPaymentResult = MonthPayment * LoanMonth;
                }
            }
            else
            {
                boolMessageDisplayed = false;
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnMonthPayment_Click(object sender, EventArgs e)
        { 
            pay();
            if (boolMessageDisplayed)
            {
                MessageBox.Show("每月付=" + MonthPayment);
            }
            else
            {
                boolMessageDisplayed = true ;
            }
        }

        public void btnTotalPayment_Click(object sender, EventArgs e)
        {
            pay();
            if (boolMessageDisplayed)
            {
                MessageBox.Show("總付款=" + TotalPaymentResult);
            }
            else
            {
                boolMessageDisplayed = true;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pay();
            if (boolMessageDisplayed)
            {
                FormLoanReport Report = new FormLoanReport((decimal)LoanYear, (decimal)YLoanRate, (decimal)LoanAmount, (decimal)MonthPayment, (decimal)TotalPaymentResult);
                Report.Show();
            }
            else
            {
                boolMessageDisplayed = true;
            }
        }
    }
}

