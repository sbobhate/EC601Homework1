using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.VideoStab;
using Emgu.CV.Util;

namespace Tracking_Application
{
    static class ImageFunctions
    {
        private static Capture videoCapture;
        private static Image<Bgr, Byte> currentFrame;

        public static Image<Bgr, Byte> CurrentFrame
        {
            get
            {
                return videoCapture.QueryFrame().ToImage<Bgr, Byte>();
            }
        }

        public static void initializeCamera()
        {
            videoCapture = new Capture(0);
            int frameWidth = (int)videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth);
            int frameHeight = (int)videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight);
            currentFrame = new Image<Bgr, Byte>(frameWidth, frameHeight);
        }
    }
}
