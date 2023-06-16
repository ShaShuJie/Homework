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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private FormHello FHello;
        private void btnHello_Click(object sender, EventArgs e)
        {
                FormHello FHello = new FormHello();
                FHello.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
                splitContainer2.Panel2.Controls.Add(FHello);
                FHello.Show();
        }

        private void btnOpenLoan_Click(object sender, EventArgs e)
        {
            FormLoan FLoan = new FormLoan();
            FLoan.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FLoan);
            FLoan.Show();
        }

        private void btnOpenPos_Click(object sender, EventArgs e)
        {
            FormPos FPos = new FormPos();
            FPos.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FPos);
            FPos.Show();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            FormCal FCal = new FormCal();
            FCal.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FCal);
            FCal.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            FormAlarm FAla = new FormAlarm();
            FAla.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FAla);
            FAla.Show();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            FormPaint FPa= new FormPaint();
            FPa.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FPa);
            FPa.Show();
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            FormStruct FSt = new FormStruct();
            FSt.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FSt);
            FSt.Show();
        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            FormGuess FGu = new FormGuess();
            FGu.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FGu);
            FGu.Show();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            FormPicture FP = new FormPicture();
            FP.TopLevel = false; // 將 TopLevel 屬性設置為 false，使其不成為獨立的頂級視窗
            splitContainer2.Panel2.Controls.Add(FP);
            FP.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
