using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Application
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            ImageFunctions.initializeCamera();
            Application.Idle += showImage;
        }
        private void showImage(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageFunctions.CurrentFrame.ToBitmap();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int red_threshold = trackBar1.Value;
            label5.Text = red_threshold.ToString();
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar1.Width) * (trackBar1.Maximum - trackBar1.Minimum);
            trackBar1.Value = Convert.ToInt32(value);
            int red_threshold = trackBar1.Value;
            label5.Text = red_threshold.ToString(); 

        }

        private void trackBar2_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar2.Width) * (trackBar2.Maximum - trackBar2.Minimum);
            trackBar2.Value = Convert.ToInt32(value);
            int green_threshold = trackBar2.Value;
            label6.Text = green_threshold.ToString(); 
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int green_threshold = trackBar2.Value;
            label6.Text = green_threshold.ToString();
        }

        private void trackBar3_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar3.Width) * (trackBar3.Maximum - trackBar3.Minimum);
            trackBar3.Value = Convert.ToInt32(value);
            int blue_threshold = trackBar3.Value;
            label7.Text = blue_threshold.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int blue_threshold = trackBar3.Value;
            label7.Text = blue_threshold.ToString();
        }
    }
}
