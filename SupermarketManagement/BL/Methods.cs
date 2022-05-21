using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SupermarketManagement.BL
{
    class Methods
    {
        public MemoryStream ms = new MemoryStream();
        public byte[] by;

        //Convert to byte
        public byte[] convert_byte()
        {
            return ms.ToArray();
        }

        //Convert byte to image
        public MemoryStream convert_image()
        {
            ms = new MemoryStream(by);
            return ms;
        }
    }
}
