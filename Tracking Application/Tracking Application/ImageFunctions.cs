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

        private static int hueLow = 0;
        private static int saturationLow = 0;
        private static int hsvValueLow = 0;
        private static int hueHigh = 255;
        private static int saturationHigh = 255;
        private static int hsvValueHigh = 255;

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
                Image<Hsv, Byte> frame = videoCapture.QueryFrame().ToImage<Hsv, Byte>();
                // Image<Hsv, Byte> thresholdImage = frame.ThresholdBinary(new Hsv((double)hueLow, (double)saturationLow, (double)hsvValueLow), new Hsv((double)hueHigh, (double)saturationHigh, (double)hsvValueHigh));
                Image<Hsv, Byte> lowFrame = new Image<Hsv, Byte>(frameWidth, frameHeight, new Hsv((double)hueLow, (double)saturationLow, (double)hsvValueLow));
                Image<Hsv, Byte> highFrame = new Image<Hsv, Byte>(frameWidth, frameHeight, new Hsv((double)hueHigh, (double)saturationHigh, (double)hsvValueHigh));
                Image<Gray, Byte> thresholdImage = frame.InRange(lowFrame, highFrame);
                outputFrame = thresholdImage;
                return outputFrame;
            }
        }
        public static int HueLow
        {
            get
            {
                return hueLow;
            }
            set
            {
                hueLow = value;
            }
        }
        public static int SaturationLow
        {
            get
            {
                return saturationLow;
            }
            set
            {
                saturationLow = value;
            }
        }
        public static int HsvValueLow
        {
            get
            {
                return hsvValueLow;
            }
            set
            {
                hsvValueLow = value;
            }
        }
        public static int HueHigh
        {
            get
            {
                return hueHigh;
            }
            set
            {
                hueHigh = value;
            }
        }
        public static int SaturationHigh
        {
            get
            {
                return saturationHigh;
            }
            set
            {
                saturationHigh = value;
            }
        }
        public static int HsvValueHigh
        {
            get
            {
                return hsvValueHigh;
            }
            set
            {
                hsvValueHigh = value;
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
    }
}
