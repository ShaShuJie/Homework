using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormAlarm : Form
    {
        private int hours, minutes, seconds;
        private bool CountingDown;
        private bool stopFlash;

        private Timer timer;
        private int moveStep = 5; // 移動的步長
        private int direction = 1; // 移動的方向，1 表示向右移動，-1 表示向左移動

        public FormAlarm()
        {
            InitializeComponent();

            pictureBox1.Visible = false;

            timer = new Timer();
            timer.Interval = 100; // 設定定時器的間隔時間，單位為毫秒
            timer.Tick += Timer_Tick; // 設定定時器的 Tick 事件處理函式
            timer.Start(); // 啟動定時器
        }
        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            labCurrentTime.Text = DateTime.Now.ToString();
        }

        private void btnCountdown_Click(object sender, EventArgs e)
        {

            // 讀取輸入時間
            if ((textBoxHour.Text == "" || (int.TryParse(textBoxHour.Text, out hours) && hours >= 0)) &&
            (textBoxMinute.Text == "" || (int.TryParse(textBoxMinute.Text, out minutes) && minutes >= 0)) &&
            (textBoxSecond.Text == "" || (int.TryParse(textBoxSecond.Text, out seconds) && seconds >= 0)))
            {
                // 啟動倒數
                CountingDown = true;
                timerCountdown.Start();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (CountingDown)
            {
                // 更新倒數計時器
                if (seconds > 0)
                    seconds--;
                else if (minutes > 0)
                {
                    minutes--;
                    seconds = 59;
                }
                else if (hours > 0)
                {
                    hours--;
                    minutes = 59;
                    seconds = 59;
                }

                // 更新顯示
                UpdateDisplay();

                // 檢查計時器是否結束
                if (hours == 0 && minutes == 0 && seconds == 0)
                {
                    CountingDown = false;
                    timerCountdown.Stop();
                    FlashBackground();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 停止計時器
            CountingDown = false;
            timerCountdown.Stop();

            // 重置計時器變數
            labHour.Text = "Hour:";
            labMinute.Text = "Minute";
            labSecond.Text = "Second:";
            textBoxHour.Text = "";
            textBoxMinute.Text = "";
            textBoxSecond.Text = "";
            hours = 0;
            minutes = 0;
            seconds = 0;

            // 停止 FlashBackground
            stopFlash = true;
            pictureBox1.Visible = false;
        }



        private void UpdateDisplay()
        {
            labHour.Text = hours.ToString("00");
            labMinute.Text = minutes.ToString("00");
            labSecond.Text = seconds.ToString("00");
        }

        private void FlashBackground()//警示螢幕
        {
            panel1.BackColor = Color.Yellow;
            stopFlash = false;
            pictureBox1.Visible = true;

            //Timer_Tick(this, new EventArgs());

            for (int i = 0; i < 50; i++)
            {
                if (stopFlash)
                {
                    break; // 跳出迴圈         
                }
                else
                {
                    panel1.BackColor = panel1.BackColor == Color.Yellow ? Color.Black : Color.Yellow;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                }
            }
            panel1.BackColor = Color.White;
            pictureBox1.Visible = false;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 更新 PictureBox 的位置
            int newX = pictureBox1.Left + (moveStep * direction);

            // 檢查是否超出 Form 的範圍，若超出則改變移動方向
            if (newX < 0 || newX + pictureBox1.Width > ClientSize.Width)
            {
                direction *= -1; // 改變方向
            }

            // 更新 PictureBox 的位置
            pictureBox1.Left = newX;
        }


    }
}

