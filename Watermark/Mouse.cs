using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watermark
{
    class Mouse
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsClicked { get; set; }

        public Mouse()
        {
            X = 0;
            Y = 0;
            IsClicked = false;
        }

    }

}
