
namespace FaceDetector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FaceRec = new System.Windows.Forms.Button();
            this.ViolaJonsBut = new System.Windows.Forms.Button();
            this.CenterButton = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FaceRec
            // 
            this.FaceRec.Location = new System.Drawing.Point(642, 383);
            this.FaceRec.Name = "FaceRec";
            this.FaceRec.Size = new System.Drawing.Size(135, 55);
            this.FaceRec.TabIndex = 1;
            this.FaceRec.Text = "Распознать Template Matching ";
            this.FaceRec.UseVisualStyleBackColor = true;
            this.FaceRec.Click += new System.EventHandler(this.FaceRec_Click);
            // 
            // ViolaJonsBut
            // 
            this.ViolaJonsBut.Location = new System.Drawing.Point(12, 383);
            this.ViolaJonsBut.Name = "ViolaJonsBut";
            this.ViolaJonsBut.Size = new System.Drawing.Size(122, 55);
            this.ViolaJonsBut.TabIndex = 2;
            this.ViolaJonsBut.Text = "Распознать Виола-Джонс";
            this.ViolaJonsBut.UseVisualStyleBackColor = true;
            this.ViolaJonsBut.Click += new System.EventHandler(this.ViolaJonsBut_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(183, 383);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(113, 55);
            this.CenterButton.TabIndex = 3;
            this.CenterButton.Text = "Center";
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(12, 12);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(765, 352);
            this.histogramBox1.TabIndex = 2;
            this.histogramBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.CenterButton);
            this.Controls.Add(this.ViolaJonsBut);
            this.Controls.Add(this.FaceRec);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FaceRec;
        private System.Windows.Forms.Button ViolaJonsBut;
        private System.Windows.Forms.Button CenterButton;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.Button button1;
    }
}

