using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.Utility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Homework
{
    public partial class FormPos : Form
    {
        public FormPos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // 設置窗口邊框樣式為固定的單個邊框
            this.Size = new Size(1085, 555);
        }
        int PenPrice = 10;
        int PistolPrice = 100;
        int ShotgunPrice = 1000;
        int RiflePrice = 10000;

        int TotalPrice = 0;

        int CountPen = 0;
        int CountPistol = 0;
        int CountShotgun = 0;
        int CountRifle = 0;

        private void buttonPen_Click(object sender, EventArgs e)
        {
            TotalPrice += PenPrice;
            labShowPayment.Text = "$ " + TotalPrice;
            CountPen = CountPen+1;
            BuyProduct();
        }

        private void btnPistol_Click(object sender, EventArgs e)
        {
            TotalPrice +=  PistolPrice;
            labShowPayment.Text = "$ " + TotalPrice;
            CountPistol += 1;
            BuyProduct();
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            TotalPrice +=  ShotgunPrice;
            labShowPayment.Text = "$ " + TotalPrice;
            CountShotgun += 1;
            BuyProduct();
        }

        private void btnRifle_Click(object sender, EventArgs e)
        {
            TotalPrice += RiflePrice;
            labShowPayment.Text = "$ " + TotalPrice;
            CountRifle += 1;
            BuyProduct();
        }

        string shoppingList = "";
        private void BuyProduct()
        {
            shoppingList = "";
            if (CountPen >= 1)
            {
                shoppingList += "\n"+"商品名：Pen，單價：" + PenPrice + "元" + "數量" + CountPen+"\n";
            }

            if (CountPistol >= 1)
            {
                shoppingList += "\n"+"商品名：Pistol，單價：" + PistolPrice + "元" + "數量" + CountPistol + "\n";
            }

            if (CountShotgun >= 1)
            {
                shoppingList += "\n"+"商品名：Shotgun，單價：" + ShotgunPrice + "元" + "數量" + CountShotgun + "\n";
            }

            if (CountRifle >= 1)
            {
                shoppingList += "\n"+"商品名： Rifle，單價：" + RiflePrice + "元" + "數量" + CountRifle + "\n";
            }
            labShowList.Text = shoppingList;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("$"+TotalPrice.ToString());
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("$"+(TotalPrice * 0.9).ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShowList.Text = "";
            TotalPrice = 0;
            labShowPayment.Text = "$0";
            CountPen = 0;
            CountPistol = 0;
            CountShotgun = 0;
            CountRifle = 0;
        }
    }
}
