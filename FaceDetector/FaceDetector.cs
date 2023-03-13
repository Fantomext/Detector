using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;

namespace FaceDetector
{
    class FaceDetector
    {

        public void TemplateMatching()
        {
            List<Point> poins = new List<Point>();
            Mat answeredPic = CvInvoke.Imread(@"C:\Users\Fantomext\source\repos\FaceDetector\FaceDetector\Artem.jpg");
            Mat aWasnsweredPic = CvInvoke.Imread(@"C:\Users\Fantomext\source\repos\FaceDetector\FaceDetector\ArtemEye.jpg");

            Mat templateOutput = new Mat();

            CvInvoke.MatchTemplate(answeredPic, aWasnsweredPic, templateOutput, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            CvInvoke.Threshold(templateOutput, templateOutput, 0.8431d, 2, Emgu.CV.CvEnum.ThresholdType.ToZero);

            var matches = templateOutput.ToImage<Gray, byte>();

            for (int i = 0; i < matches.Rows; i++)
            {
                for (int y = 0; y < matches.Cols; y++)
                {
                    if (matches[i, y].Intensity > 0.55)
                    {
                        poins.Add(new Point(y, i));
                    }
                }
            }

            Point center = poins[0];
            for (int i = 1; i < poins.Count; i++)
            {
                center.X += poins[i].X;
                center.Y += poins[i].Y;
            }

            center.X = center.X / poins.Count;
            center.Y = center.Y / poins.Count;

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(center, aWasnsweredPic.Size);

            CvInvoke.Rectangle(answeredPic, rect, new Emgu.CV.Structure.MCvScalar(0, 0, 240), 2);

            CvInvoke.Imshow("template", answeredPic);

            CvInvoke.WaitKey();
        }

        public void ViolaDetection()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()== DialogResult.OK)
            {
                Image<Bgr, byte> imgInput = new Image<Bgr, byte>(dialog.FileName);
                
            }
            else
            {
                throw new Exception("Не выбран файл");
            }
        }
    }
}

