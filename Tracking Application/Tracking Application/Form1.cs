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

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.BlueThreshold = blueTrackBar.Value;
            blueLabel.Text = ImageFunctions.BlueThreshold.ToString();
        }

        private void blueTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)blueTrackBar.Width) * (blueTrackBar.Maximum - blueTrackBar.Minimum);
            blueTrackBar.Value = (int) value;
            ImageFunctions.BlueThreshold = (int) value;
            blueLabel.Text = ImageFunctions.BlueThreshold.ToString();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.GreenThreshold = greenTrackBar.Value;
            greenLabel.Text = ImageFunctions.GreenThreshold.ToString();
        }

        private void greenTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)greenTrackBar.Width) * (greenTrackBar.Maximum - greenTrackBar.Minimum);
            greenTrackBar.Value = (int)value;
            ImageFunctions.GreenThreshold = (int)value;
            greenLabel.Text = ImageFunctions.GreenThreshold.ToString();
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageFunctions.RedThreshold = redTrackBar.Value;
            redLabel.Text = ImageFunctions.RedThreshold.ToString();
        }

        private void redTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double value = ((double)e.X / (double)redTrackBar.Width) * (redTrackBar.Maximum - redTrackBar.Minimum);
            redTrackBar.Value = (int)value;
            ImageFunctions.RedThreshold = (int)value;
            redLabel.Text = ImageFunctions.RedThreshold.ToString();
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
    }
}
