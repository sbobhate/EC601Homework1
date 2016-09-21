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
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            ImageFunctions.initializeCamera();
            Application.Idle += showImage;
        }

        private void showImage(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageFunctions.CurrentFrame.ToBitmap();
            pictureBox2.Image = ImageFunctions.BinaryFrame.ToBitmap();
            pictureBox3.Image = ImageFunctions.OutputFrame.ToBitmap();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFunctions.saveImage(saveFileDialog.FileName + ".png");
            }
        }

        private void hueLowTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.HueLow = hueLowTrackBar.Value;
            hueLowLabel.Text = ImageFunctions.HueLow.ToString();
        }

        private void hueLowTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)hueLowTrackBar.Width) * (hueLowTrackBar.Maximum - hueLowTrackBar.Minimum);
            hueLowTrackBar.Value = (int)value;
            ImageFunctions.HueLow = (int)value;
            hueLowLabel.Text = ImageFunctions.HueLow.ToString();
        }

        private void saturationLowTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.SaturationLow = saturationLowTrackBar.Value;
            saturationLowLabel.Text = ImageFunctions.SaturationLow.ToString();
        }

        private void saturationLowTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)saturationLowTrackBar.Width) * (saturationLowTrackBar.Maximum - saturationLowTrackBar.Minimum);
            saturationLowTrackBar.Value = (int)value;
            ImageFunctions.SaturationLow = (int)value;
            saturationLowLabel.Text = ImageFunctions.SaturationLow.ToString();
        }

        private void valueLowTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.ValueLow = valueLowTrackBar.Value;
            valueLowLabel.Text = ImageFunctions.ValueLow.ToString();
        }

        private void valueLowTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)valueLowTrackBar.Width) * (valueLowTrackBar.Maximum - valueLowTrackBar.Minimum);
            valueLowTrackBar.Value = (int)value;
            ImageFunctions.ValueLow = (int)value;
            valueLowLabel.Text = ImageFunctions.ValueLow.ToString();
        }

        private void hueHighTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.HueHigh = hueHighTrackBar.Value;
            hueHighLabel.Text = ImageFunctions.HueHigh.ToString();
        }

        private void hueHighTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)hueHighTrackBar.Width) * (hueHighTrackBar.Maximum - hueHighTrackBar.Minimum);
            hueHighTrackBar.Value = (int)value;
            ImageFunctions.HueHigh = (int)value;
            hueHighLabel.Text = ImageFunctions.HueHigh.ToString();
        }

        private void saturationHighTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.SaturationHigh = saturationHighTrackBar.Value;
            saturationHighLabel.Text = ImageFunctions.SaturationHigh.ToString();
        }

        private void saturationHighTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)saturationHighTrackBar.Width) * (saturationHighTrackBar.Maximum - saturationHighTrackBar.Minimum);
            saturationHighTrackBar.Value = (int)value;
            ImageFunctions.SaturationHigh = (int)value;
            saturationHighLabel.Text = ImageFunctions.SaturationHigh.ToString();
        }

        private void valueHighTrackbBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.ValueHigh = valueHighTrackBar.Value;
            valueHighLabel.Text = ImageFunctions.ValueHigh.ToString();
        }

        private void valueHighTrackbBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)valueHighTrackBar.Width) * (valueHighTrackBar.Maximum - valueHighTrackBar.Minimum);
            valueHighTrackBar.Value = (int)value;
            ImageFunctions.ValueHigh = (int)value;
            valueHighLabel.Text = ImageFunctions.ValueHigh.ToString();
        }
    }
}
