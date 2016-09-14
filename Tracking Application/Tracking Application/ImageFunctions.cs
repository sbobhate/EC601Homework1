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
        private static Image<Gray, Byte> outputFrame;
        private static int frameWidth = 0, frameHeight = 0;

        private static int rThreshold = 50;
        private static int bThreshold = 50;
        private static int gThreshold = 50;

        public static Image<Bgr, Byte> CurrentFrame
        {
            get
            {
                return videoCapture.QueryFrame().ToImage<Bgr, Byte>();
            }
        }
        public static Image<Gray, Byte> OutputFrame
        {
            get
            {
                Image<Bgr, Byte> frame = videoCapture.QueryFrame().ToImage<Bgr, Byte>();
                Image<Bgr, Byte> thresholdImage = frame.ThresholdBinary(new Bgr(bThreshold, gThreshold, rThreshold), new Bgr(255, 255, 255));
                outputFrame = thresholdImage.Convert<Gray, Byte>();
                return outputFrame;
            }
        }
        public static int RThreshold
        {
            get
            {
                return rThreshold;
            }
            set
            {
                rThreshold = value;
            }
        }
        public static int BThreshold
        {
            get
            {
                return bThreshold;
            }
            set
            {
                bThreshold = value;
            }
        }
        public static int GThreshold
        {
            get
            {
                return gThreshold;
            }
            set
            {
                gThreshold = value;
            }
        }

        public static void initializeCamera()
        {
            videoCapture = new Capture(0);
            frameWidth = (int)videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth);
            frameHeight = (int)videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight);
            currentFrame = new Image<Bgr, Byte>(frameWidth, frameHeight);
            outputFrame = new Image<Gray, Byte>(frameWidth, frameHeight);
        }

        public static void processFrame(object sender, EventArgs e)
        {

        }
    }
}
