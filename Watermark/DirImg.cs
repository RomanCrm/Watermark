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
    class DirImg
    {
        public List<Image> Images { get; set; }
        public bool IsFolder { get; set; }

        public DirImg()
        {
            Images = null;
            IsFolder = false;
        }

        public void AfterSelectFolder(DirImg dirImg, Extension extensions, SoloImg soloImg)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dirImg.Images = new List<Image>();

                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    string ext = Path.GetExtension(file.FullName);
                    if (extensions.AllowImageExt.Contains(ext))
                    {
                        dirImg.Images.Add(Image.FromFile(file.FullName));
                        soloImg.PathImage = file.FullName;
                    }
                }

                dirImg.IsFolder = true;
            }
        }

        public void IfDirText(Graphics g, DirImg dirImg, Mouse mouse, PictureBox pictureBox1, TextW textW)
        {
            foreach (Image image in dirImg.Images)
            {
                Counter.Count++;
                OriginCoordinate.X = (image.Width * mouse.X) / pictureBox1.Width;
                OriginCoordinate.Y = (image.Height * mouse.Y) / pictureBox1.Height;

                Bitmap b = new Bitmap(image.Width, image.Height);
                using (g = Graphics.FromImage(b))
                {
                    g.DrawImage(image, 0, 0, image.Width, image.Height);
                    g.DrawString(textW.TextWatermark, new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, OriginCoordinate.X, OriginCoordinate.Y);
                }
                b.Save(@"pictures with a watermark/Copy_" + Counter.Count.ToString() + ".bmp");
            }
        }

        public void IfDirImg(Graphics g, DirImg dirImg, Mouse mouse, PictureBox pictureBox1, ImgW imgW)
        {
            foreach (Image image in dirImg.Images)
            {
                Counter.Count++;
                OriginCoordinate.X = (image.Width * mouse.X) / pictureBox1.Width;
                OriginCoordinate.Y = (image.Height * mouse.Y) / pictureBox1.Height;

                Bitmap b = new Bitmap(image.Width, image.Height);
                using (g = Graphics.FromImage(b))
                {
                    g.DrawImage(image, 0, 0, image.Width, image.Height);
                    g.DrawImage(imgW.ImgWatermark, OriginCoordinate.X, OriginCoordinate.Y, 85, 85);
                }
                b.Save(@"pictures with a watermark/Copy_" + Counter.Count.ToString() + ".bmp");
            }
        }

    }

}
