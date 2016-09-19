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

        private static int blueThreshold = 0;
        private static int redThreshold = 0;
        private static int greenThreshold = 0;
        private static int maxThreshold = 255;

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
                Image<Bgr, Byte> thresholdImage = frame.ThresholdBinary(new Bgr(blueThreshold, greenThreshold, redThreshold), new Bgr(maxThreshold, maxThreshold, maxThreshold));
                Image<Gray, Byte> outputImage = thresholdImage.Convert<Gray, Byte>();
                CvInvoke.Threshold(outputImage, outputImage, 100, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                return outputImage;
            }
        }
        public static int BlueThreshold
        {
            get
            {
                return blueThreshold;
            }
            set
            {
                blueThreshold = value;
            }
        }
        public static int GreenThreshold
        {
            get
            {
                return greenThreshold;
            }
            set
            {
                greenThreshold = value;
            }
        }
        public static int RedThreshold
        {
            get
            {
                return redThreshold;
            }
            set
            {
                redThreshold = value;
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

        public static void saveImage(string fileName)
        {
            OutputFrame.Save(fileName);
        }
    }
}
