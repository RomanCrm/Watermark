using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    enum Watermarks
    {
        ImageWatermark,
        TextWatermark
    }

    public partial class Form1 : Form
    {
        Graphics g;

        TextW textW;
        ImgW imgW;
        Mouse mouse;

        SoloImg soloImg;
        DirImg dirImg;

        Extension extensions;

        bool isSaveClicked = false;

        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();

            InitExamples();

            Paint += Form_Paint;
        }

        private void InitExamples()
        {
            textW = new TextW();
            imgW = new ImgW();
            mouse = new Mouse();

            soloImg = new SoloImg();
            dirImg = new DirImg();

            extensions = new Extension(".jpg", ".png", ".jpeg", ".bmp");
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            ReDrawEveryTime();
        }

        private void ReDrawEveryTime()
        {
            if (soloImg.PathImage != null)
            {
                soloImg.DrawStart(g, textWatermarkBtn, imageWatermarkBtn, soloImg, pictureBox1);
            }

            if (textW.IsMoveText)
            {
                textW.MoveTextDraw(g, textW, mouse);
            }
            if (textW.IsTextWatermark)
            {
                textW.IfTextWatermark(g, textW, mouse, saveBtn);
            }

            if (imgW.IsMoveImg)
            {
                if (imgW.ImgWatermark != null)
                {
                    imgW.MoveImgDraw(g, imgW, mouse);
                }
            }
            if (imgW.IsImgWatermark)
            {
                imgW.IfImgWatermark(g, imgW, mouse, saveBtn);
            }

            if (isSaveClicked)
            {
                if (!dirImg.IsFolder)
                {
                    OriginCoordinate.X = (soloImg.Image.Width * mouse.X) / pictureBox1.Width;
                    OriginCoordinate.Y = (soloImg.Image.Height * mouse.Y) / pictureBox1.Height;

                    Counter.Count++;

                    if (textW.TextWatermark != "" && imgW.ImgWatermark == null)
                    {
                        soloImg.IfWaterText(g, soloImg, textW);
                    }
                    if (textW.TextWatermark == "" && imgW.ImgWatermark != null)
                    {
                        soloImg.IfWaterImg(g, soloImg, imgW);
                    }
                }
                else
                {
                    Counter.Count = -1;

                    DirectoryInfo directory = Directory.CreateDirectory("pictures with a watermark");
                    if (textW.TextWatermark != "" && imgW.ImgWatermark == null)
                    {
                        dirImg.IfDirText(g, dirImg, mouse, pictureBox1, textW);
                    }
                    if (textW.TextWatermark == "" && imgW.ImgWatermark != null)
                    {
                        dirImg.IfDirImg(g, dirImg, mouse, pictureBox1, imgW);
                    }
                }

                isSaveClicked = false;
            }
        }

        private void SelectFolder_Clicked(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            dirImg.AfterSelectFolder(dirImg, extensions, soloImg);
            Invalidate();
        }
        private void SelectFile_Clicked(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            soloImg.AfterSelectFile(extensions, dirImg, soloImg);
            Invalidate();
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            isSaveClicked = true;
            Invalidate();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            textW.IsMoveText = true;
            imgW.IsMoveImg = true;
            if (mouse.IsClicked)
            {
                mouse.X = e.X;
                mouse.Y = e.Y;

                Invalidate();
            }
        }
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouse.IsClicked = false;
            textW.IsMoveText = false;
            imgW.IsMoveImg = false;
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouse.X = e.X;
            mouse.Y = e.Y;
            mouse.IsClicked = true;
        }

        private void TextWatermark_Clicked(object sender, EventArgs e)
        {
            OpenWatermarkEditor(Watermarks.TextWatermark.ToString());
        }
        private void ImageWaterrmark_Clicked(object sender, EventArgs e)
        {
            OpenWatermarkEditor(Watermarks.ImageWatermark.ToString());
        }
        private void OpenWatermarkEditor(string formName)
        {
            if (formName == "ImageWatermark")
            {
                ImageWatermark imageWatermark = new ImageWatermark();
                if (imageWatermark.ShowDialog() == DialogResult.OK)
                {
                    imgW.IsImgWatermark = true;
                    textW.TextWatermark = "";
                    imgW.ImgWatermark = imageWatermark.Logo;
                    Invalidate();
                }
            }
            else
            {
                TextWatermark textWatermark = new TextWatermark();
                if (textWatermark.ShowDialog() == DialogResult.OK)
                {
                    textW.IsTextWatermark = true;
                    imgW.ImgWatermark = null;
                    textW.TextWatermark = textWatermark.TextBox;
                    Invalidate();
                }
            }
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            Close();
        }

    }

}
