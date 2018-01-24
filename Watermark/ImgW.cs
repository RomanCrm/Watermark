using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    class ImgW
    {
        public Image ImgWatermark { get; set; }
        public bool IsImgWatermark { get; set; }
        public bool IsMoveImg { get; set; }

        public ImgW()
        {
            ImgWatermark = null;
            IsImgWatermark = false;
            IsMoveImg = false;
        }

        public void MoveImgDraw(Graphics g, ImgW imgW, Mouse mouse)
        {
            g.DrawImage(imgW.ImgWatermark, mouse.X, mouse.Y, 50, 50);
            imgW.IsMoveImg = false;
        }

        public void IfImgWatermark(Graphics g, ImgW imgW, Mouse mouse, ToolStripMenuItem saveBtn)
        {
            g.DrawImage(imgW.ImgWatermark, mouse.X, mouse.Y, 50, 50);
            saveBtn.Enabled = true;
            imgW.IsImgWatermark = false;
        }

    }

}
