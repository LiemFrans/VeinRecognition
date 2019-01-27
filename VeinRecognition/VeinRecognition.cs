using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeinRecognition
{
    public partial class VeinRecognition : Form
    {
        public VeinRecognition()
        {
            InitializeComponent();
        }

        private void btLoadDataTraining_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp;...";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbTraining.Image = new Bitmap(dlg.FileName);
                    log(dlg.FileName);
                    pbTraining.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btExtract_Click(object sender, EventArgs e)
        {
            log("Feature Training");
            glcm(pbTraining.Image);
        }

        private void glcm(Image image)
        {
            progress.Maximum = 7;
            progress.Value = 0;
            GLCMFeatureExtraction glcm = new GLCMFeatureExtraction(image, 10);
            progress.Value++;
            glcm.extract();
            progress.Value++;
            log("Contrast : " + glcm.getContrast());
            progress.Value++;
            log("Disimiliarity : " + glcm.getDissimilarity());
            progress.Value++;
            log("Energy : " + glcm.getEnergy());
            progress.Value++;
            log("Entropy : " + glcm.getEntropy());
            progress.Value++;
            log("Homogenity : " + glcm.getHomogenity());
            progress.Value++;
        }

        private void log(String log)
        {
            rcLog.Text += (log + "\n");
        }

        private void btLoadDataTesting_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp;...";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbTesting.Image = new Bitmap(dlg.FileName);
                    log(dlg.FileName);
                    pbTesting.SizeMode = PictureBoxSizeMode.Zoom;
                    log("Feature Testing");
                    glcm(pbTesting.Image);
                }
            }
        }

        private void btCompare_Click(object sender, EventArgs e)
        {

        }
    }
}
