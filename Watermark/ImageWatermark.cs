using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    public partial class ImageWatermark : Form
    {
        private readonly string pathNo = "imageWatermark/no.png";
        private readonly string pathYes = "imageWatermark/yes.png";

        public Image Logo { get; set; }

        string[] allowImageExt = { ".jpg", ".png", ".jpeg", ".bmp" };

        public ImageWatermark()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(pathNo);
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Apply_Clicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Download_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog.FileName);
                if (allowImageExt.Contains(ext))
                {
                    Logo = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = Image.FromFile(pathYes);
                }
            }
        }

    }

}
