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
        private static int valueLow = 0;
        private static int hueHigh = 179;
        private static int saturationHigh = 255;
        private static int valueHigh = 255;

        private static Image<Hsv, Byte> lowerThreshold;
        private static Image<Hsv, Byte> higherThreshold;

        public static Image<Bgr, Byte> CurrentFrame
        {
            get
            {
                currentFrame = videoCapture.QueryFrame().ToImage<Bgr, Byte>();
                return currentFrame;
            }
        }
        public static Image<Gray, Byte> BinaryFrame
        {
            get
            {
                Image<Bgr, Byte> frame = videoCapture.QueryFrame().ToImage<Bgr, Byte>();
                CvInvoke.GaussianBlur(frame, frame, new Size(3, 3), 0);
                Image<Hsv, Byte> filteredFrame = new Image<Hsv, Byte>(frameWidth, frameHeight);
                CvInvoke.CvtColor(frame, filteredFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                lowerThreshold = new Image<Hsv, Byte>(frameWidth, frameHeight, new Hsv(hueLow, saturationLow, valueLow));
                higherThreshold = new Image<Hsv, Byte>(frameWidth, frameHeight, new Hsv(hueHigh, saturationHigh, valueHigh));

                Image<Gray, Byte> binaryImage = new Image<Gray, Byte>(frameWidth, frameHeight);
                CvInvoke.InRange(filteredFrame, lowerThreshold, higherThreshold, binaryImage);

                CvInvoke.Dilate(binaryImage, binaryImage, new Mat(), new Point(0, 0), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());

                Image<Gray, Byte> copyBinary = binaryImage.Clone();
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                VectorOfPoint heir = new VectorOfPoint();
                CvInvoke.FindContours(copyBinary, contours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple, new Point(0,0));

                if (contours.Size != 0)
                {
                    int idx = 0;
                    double maxArea = 0;
                    for (int ii = 0; ii < contours.Size; ++ii)
                    {
                        double area = CvInvoke.ContourArea(contours[ii]);
                        if (area > maxArea)
                        {
                            maxArea = area;
                            idx = ii;
                        }
                    }

                    CvInvoke.DrawContours(currentFrame, contours, idx, new MCvScalar(0, 255, 0));
                }

                return binaryImage;
            }
        }
        public static Image<Bgr, Byte> OutputFrame
        {
            get
            {
                return currentFrame;
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
        public static int ValueLow
        {
            get
            {
                return valueLow;
            }
            set
            {
                valueLow = value;
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
        public static int ValueHigh
        {
            get
            {
                return valueHigh;
            }
            set
            {
                valueHigh = value;
            }
        }

        public static Image<Bgr, Byte> LowerThresholdColor
        {
            get
            {
                Image<Bgr, Byte> result = new Image<Bgr, Byte>(frameWidth, frameHeight);
                CvInvoke.CvtColor(lowerThreshold, result, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
                return result;
            }
        }
        public static Image<Bgr, Byte> HigherThresholdColor
        {
            get
            {
                Image<Bgr, Byte> result = new Image<Bgr, Byte>(frameWidth, frameHeight);
                CvInvoke.CvtColor(higherThreshold, result, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
                return result;
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
            currentFrame.Save(fileName);
        }
    }
}
