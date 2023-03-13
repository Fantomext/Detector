using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
    }
}
