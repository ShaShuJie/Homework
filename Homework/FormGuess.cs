using System;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormGuess : Form
    {
        public FormGuess()
        {
            InitializeComponent();
        }
        
        public int FGRandomNumber;
        Random random = new Random();

        public void btnGuess_Click(object sender, EventArgs e)
        {
            FGRandomNumber = random.Next(101); // 生成 0 到 100 之間的隨機整數
            FormGuessInput FGI = new FormGuessInput(FGRandomNumber, this);
            DialogResult result = FGI.ShowDialog();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FGRandomNumber.ToString());
        }
    }
}
