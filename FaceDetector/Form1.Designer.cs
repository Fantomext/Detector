
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FaceRec = new System.Windows.Forms.Button();
            this.ViolaJonsBut = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 351);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.ViolaJonsBut);
            this.Controls.Add(this.FaceRec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FaceRec;
        private System.Windows.Forms.Button ViolaJonsBut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

