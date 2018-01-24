using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watermark
{
    class Extension
    {
        public string[] AllowImageExt { get; set; }

        public Extension(params string[] exts)
        {
            AllowImageExt = exts;
        }
    }
}
