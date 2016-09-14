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
    }
}
