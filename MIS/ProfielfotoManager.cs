using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIS.Properties;

namespace MIS
{
    class ProfielfotoManager
    {

        public static Bitmap getProfielfoto(int userid)
        {
            int fotoid = userid % 50;
            return (Bitmap) Resources.ResourceManager.GetObject("foto" + fotoid);
        }
    }
}
