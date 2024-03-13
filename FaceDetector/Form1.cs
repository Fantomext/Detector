using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;



namespace FaceDetector
{
    
    public partial class Form1 : Form
    {
        FaceDetector faceDetector = new FaceDetector();
        public Form1()
        {
            InitializeComponent();
        }

        private void FaceRec_Click(object sender, EventArgs e)
        {
            faceDetector.TemplateMatching();
        }

        private void ViolaJonsBut_Click(object sender, EventArgs e)
        {
            faceDetector.ViolaDetection();
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            faceDetector.CenterLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Histogramm();
        }

        public void Histogramm()
        {

            Image<Bgr, byte> inputImage = new Image<Bgr, byte>("myPhoto.jpg");
            Image<Gray, Byte> red = inputImage[0];
            Image<Gray, Byte> green = inputImage[1];
            Image<Gray, Byte> blue = inputImage[2];

            var forward = new Image<Gray, float>(inputImage.Rows, inputImage.Cols);

            histogramBox1.ClearHistogram();

            histogramBox1.GenerateHistograms(red, 256);
            histogramBox1.GenerateHistograms(green, 256);
            histogramBox1.GenerateHistograms(blue, 256);



        }

        
    }
}
