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
    public partial class FormPaint : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Pen drawingPen = new Pen(Color.Black, 2);
        private Bitmap canvasBitmap;

        public FormPaint()
        {
            InitializeComponent();
            canvasBitmap = new Bitmap(pictureBoxPaint.Width, pictureBoxPaint.Height);
            pictureBoxPaint.Image = canvasBitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.DrawLine(drawingPen, previousPoint, e.Location);
                    previousPoint = e.Location;
                }

                pictureBoxPaint.Refresh();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                drawingPen.Color = colorDialog.Color;
            }
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = trackBarThickness.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White); // 清除畫布，填滿白色背景
            }

            pictureBoxPaint.Refresh(); // 更新畫布圖像
        }
    }
}
