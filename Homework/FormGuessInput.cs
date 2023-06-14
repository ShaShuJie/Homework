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
    public partial class FormGuessInput : Form
    {
        private int FGIRandomNumber;
        private FormGuess FG;
        int Maxnum = 100;
        int Minnum = 0;
        int InputNum;

        public FormGuessInput(int randomnum, FormGuess formguess)
        {
            InitializeComponent();
            FGIRandomNumber = randomnum;
            FG = formguess;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textInput.Text,out InputNum)&& InputNum>=0 && InputNum<=100)
            {
                if (InputNum == FGIRandomNumber)
                {
                    MessageBox.Show("答對了");
                }
                else if (InputNum > FGIRandomNumber)
                {
                    Maxnum = InputNum;
                    MessageBox.Show($"介於{Minnum}到{Maxnum}之間");
                }
                else if (InputNum < FGIRandomNumber)
                {
                    Minnum = InputNum;
                    MessageBox.Show($"介於{Minnum}到{Maxnum}之間");
                }
            }
            else
            {
                MessageBox.Show("請輸入0~100的整數");
            }

            FG.labShow.Text = $"介於{Minnum}到{Maxnum}之間";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FG.labShow.Text = $"Select A Number";
        }
    }
}
