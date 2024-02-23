using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_flori
{
    public class Flori
    {
        public int fire;
        public int pret;
        public string flori;

        public string BuchetFlori()
        {
            string text = " ";
            text += "Cate fire " + fire + "\n";
            text += "Pretul" + pret + "\n";
            text += "FLori " + flori + "\n";
            return text;
        }
    }
}
