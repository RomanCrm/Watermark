using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    class SoloImg
    {
        public Image Image { get; set; }

        public string PathImage { get; set; }

        public SoloImg()
        {
            Image = null;
            PathImage = null;
        }

        public void DrawStart(Graphics g, ToolStripMenuItem textWatermarkBtn, ToolStripMenuItem imageWatermarkBtn, SoloImg soloImg, PictureBox pictureBox1)
        {
            textWatermarkBtn.Enabled = true;
            imageWatermarkBtn.Enabled = true;
            soloImg.Image = Image.FromFile(soloImg.PathImage);
            g.DrawImage(soloImg.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        public void AfterSelectFile(Extension extensions, DirImg dirImg, SoloImg soloImg)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog.FileName);
                if (extensions.AllowImageExt.Contains(ext))
                {
                    dirImg.IsFolder = false;
                    soloImg.PathImage = openFileDialog.FileName;
                }
            }
        }

        public void IfWaterText(Graphics g, SoloImg soloImg, TextW textW)
        {
            Bitmap b = new Bitmap(soloImg.Image.Width, soloImg.Image.Height);
            using (g = Graphics.FromImage(b))
            {
                g.DrawImage(soloImg.Image, 0, 0, soloImg.Image.Width, soloImg.Image.Height);
                g.DrawString(textW.TextWatermark, new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, OriginCoordinate.X, OriginCoordinate.Y);
            }
            b.Save("Copy_TextW_" + Counter.Count.ToString() + ".bmp");
        }

        public void IfWaterImg(Graphics g, SoloImg soloImg, ImgW imgW)
        {
            Bitmap b = new Bitmap(soloImg.Image.Width, soloImg.Image.Height);
            using (g = Graphics.FromImage(b))
            {
                g.DrawImage(soloImg.Image, 0, 0, soloImg.Image.Width, soloImg.Image.Height);
                g.DrawImage(imgW.ImgWatermark, OriginCoordinate.X, OriginCoordinate.Y, 85, 85);
            }
            b.Save("Copy_ImgW_" + Counter.Count.ToString() + ".bmp");
        }

    }

}
