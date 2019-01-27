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
    public partial class ImageForm : Form
    {
        public ImageForm(Image image)
        {
            InitializeComponent();
            imageBox.Image = image;
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
