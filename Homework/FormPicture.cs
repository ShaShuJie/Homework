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
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Zoom((PictureBox)sender);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Zoom((PictureBox)sender);
        }
        private void Zoom(PictureBox pictureBox)
        {
            FormPictureZoom pictureZoom = new FormPictureZoom(pictureBox.Image);
            pictureZoom.ShowDialog();
        }


    }
}
