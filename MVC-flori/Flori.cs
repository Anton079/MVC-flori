using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_flori
{
    public class Flori
    {
        private int _fire;
        private int _pret;
        private string _flori;

        public int fire
        {
            get { return _fire; }
            set { _fire = value; }
        }

        public int pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        public string flori
        {
            get { return _flori; }
            set { _flori = value; }
        }

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
