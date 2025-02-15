﻿using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;




namespace FaceDetector
{
    class FaceDetector
    {
        
        public void TemplateMatching()
        {
            List<Point> poins = new List<Point>();

            Mat answeredPic = CvInvoke.Imread("myPhoto.jpg");
            Mat aWasnsweredPic = CvInvoke.Imread("Template/Mouth.png");

            Mat templateOutput = new Mat();
            
            CvInvoke.MatchTemplate(answeredPic, aWasnsweredPic, templateOutput, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            CvInvoke.Imshow("templateOutput", templateOutput);

            CvInvoke.Threshold(templateOutput, templateOutput, 0, 2, Emgu.CV.CvEnum.ThresholdType.ToZero);

            CvInvoke.Imshow("templateOutput", templateOutput);

            var matches = templateOutput.ToImage<Gray, byte>();

            for (int i = 0; i < matches.Rows; i++)
            {
                for (int y = 0; y < matches.Cols; y++)
                {
                    if (matches[i, y].Intensity > 0.0)
                    {
                        poins.Add(new Point(y, i));
                    }
                }
            }

            if (poins.Count != 0)
            {
                Point center = poins[0];
                for (int i = 1; i < poins.Count; i++)
                {
                    center.X += poins[i].X;
                    center.Y += poins[i].Y;
                }

                center.X = center.X / poins.Count;
                center.Y = center.Y / poins.Count;

                Rectangle rect = new Rectangle(center, aWasnsweredPic.Size);

                CvInvoke.Rectangle(answeredPic, rect, new MCvScalar(0, 0, 240), 2);

                answeredPic.Save("resultMatch.jpg");

                CvInvoke.Imshow("template", answeredPic);

                CvInvoke.WaitKey();
            }
            
        }


        public void ViolaDetection()
        {
            Image<Bgr, byte> image = new Image<Bgr, byte>("17374.jpg");
            CascadeClassifier faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
            var faces = faceCascade.DetectMultiScale(image, 1.25, 3);
            foreach (var face in faces)
            {
                image.Draw(face, new Bgr(Color.Green), 2);
            }

            image.Save("resultMatchArt.jpg");
            CvInvoke.Imshow("Wtf", image);
            CvInvoke.WaitKey();
        }

        public void CenterLine()
        {
            Image<Bgr, byte> image = new Image<Bgr, byte>("myPhoto.jpg");
            CascadeClassifier noseCascade = new CascadeClassifier("haarcascade_mcs_nose.xml");
            CascadeClassifier eyeCascade = new CascadeClassifier("haarcascade_eye.xml");
            var noses = noseCascade.DetectMultiScale(image, 3, 1);

            LineSegment2D centralLine = new LineSegment2D(new Point(noses[0].X + noses[0].Width/2, 0), new Point(noses[0].X + noses[0].Width/2, image.Height));

            CvInvoke.Line(image, centralLine.P1, centralLine.P2, new MCvScalar(0, 0, 240));

            var eyes = eyeCascade.DetectMultiScale(image, 1.3, 3);

            LineSegment2D leftLine = LineCreator(eyes[0]);
            LineSegment2D rightLine = LineCreator(eyes[1]);

            CvInvoke.Line(image, leftLine.P1, leftLine.P2, new MCvScalar(0, 0, 240));
            CvInvoke.Line(image, rightLine.P1, rightLine.P2, new MCvScalar(0, 0, 240));

            image.Save("resultMatchArt.jpg");
            CvInvoke.Imshow("Center", image);
            CvInvoke.WaitKey();

        }

        public LineSegment2D LineCreator(Rectangle rect)
        {
            LineSegment2D line = new LineSegment2D(new Point(rect.X + rect.Width / 2, 0), new Point(rect.X + rect.Width / 2, 1920));
            return line;
        }
    }
}

