using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormLoanReport : Form
    {
        public FormLoanReport(decimal LoanYear, decimal YLoanRate, decimal LoanAmount, decimal MonthPayment, decimal TotalPaymentResult)
        {
            InitializeComponent();
            textRELoanAmount.Text = LoanAmount.ToString();
            textRELoanYear.Text = LoanYear.ToString();
            textRELoanRate.Text = YLoanRate.ToString();
            textREMonthPaymentResult.Text = MonthPayment.ToString();
            textRETotalPaymentResult.Text = TotalPaymentResult.ToString();
        }
    }
}
