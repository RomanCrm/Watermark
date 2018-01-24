using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    class TextW
    {
        public string TextWatermark { get; set; }
        public bool IsTextWatermark { get; set; }
        public bool IsMoveText { get; set; }

        public TextW()
        {
            TextWatermark = string.Empty;
            IsTextWatermark = false;
            IsMoveText = false;
        }

        public void IfTextWatermark(Graphics g, TextW textW, Mouse mouse, ToolStripMenuItem saveBtn)
        {
            g.DrawString(textW.TextWatermark, new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, mouse.X, mouse.Y);
            saveBtn.Enabled = true;
            textW.IsTextWatermark = false;
        }

        public void MoveTextDraw(Graphics g, TextW textW, Mouse mouse)
        {
            g.DrawString(textW.TextWatermark, new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, mouse.X, mouse.Y);
            textW.IsMoveText = false;
        }

    }

}
