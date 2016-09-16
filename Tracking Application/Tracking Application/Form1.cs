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
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            ImageFunctions.initializeCamera();
            Application.Idle += showImage;
        }
        private void showImage(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageFunctions.CurrentFrame.ToBitmap();
            pictureBox2.Image = ImageFunctions.OutputFrame.ToBitmap();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int red_threshold = trackBar1.Value;
            label5.Text = red_threshold.ToString();
            ImageFunctions.HueLow = red_threshold; 
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar1.Width) * (trackBar1.Maximum - trackBar1.Minimum);
            trackBar1.Value = Convert.ToInt32(value);
            int red_threshold = trackBar1.Value;
            label5.Text = red_threshold.ToString();
            ImageFunctions.HueLow = red_threshold;

        }

        private void trackBar2_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar2.Width) * (trackBar2.Maximum - trackBar2.Minimum);
            trackBar2.Value = Convert.ToInt32(value);
            int green_threshold = trackBar2.Value;
            label6.Text = green_threshold.ToString();
            ImageFunctions.SaturationLow = green_threshold;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int green_threshold = trackBar2.Value;
            label6.Text = green_threshold.ToString();
            ImageFunctions.SaturationLow = green_threshold;
        }

        private void trackBar3_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar3.Width) * (trackBar3.Maximum - trackBar3.Minimum);
            trackBar3.Value = Convert.ToInt32(value);
            int blue_threshold = trackBar3.Value;
            label7.Text = blue_threshold.ToString();
            ImageFunctions.HsvValueLow = blue_threshold;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int blue_threshold = trackBar3.Value;
            label7.Text = blue_threshold.ToString();
            ImageFunctions.HsvValueLow = blue_threshold;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            int blue_threshold = trackBar6.Value;
            label9.Text = blue_threshold.ToString();
            ImageFunctions.HueHigh = blue_threshold;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            int blue_threshold = trackBar5.Value;
            label10.Text = blue_threshold.ToString();
            ImageFunctions.SaturationHigh = blue_threshold;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int blue_threshold = trackBar4.Value;
            label11.Text = blue_threshold.ToString();
            ImageFunctions.HsvValueHigh = blue_threshold;
        }

        private void trackBar6_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar6.Width) * (trackBar6.Maximum - trackBar6.Minimum);
            trackBar6.Value = Convert.ToInt32(value);
            int blue_threshold = trackBar6.Value;
            label9.Text = blue_threshold.ToString();
            ImageFunctions.HueHigh = blue_threshold;
        }

        private void trackBar5_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar5.Width) * (trackBar5.Maximum - trackBar5.Minimum);
            trackBar5.Value = Convert.ToInt32(value);
            int blue_threshold = trackBar5.Value;
            label10.Text = blue_threshold.ToString();
            ImageFunctions.SaturationHigh = blue_threshold;
        }

        private void trackBar4_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)trackBar4.Width) * (trackBar4.Maximum - trackBar4.Minimum);
            trackBar4.Value = Convert.ToInt32(value);
            int blue_threshold = trackBar4.Value;
            label11.Text = blue_threshold.ToString();
            ImageFunctions.HsvValueHigh = blue_threshold;
        }
    }
}
