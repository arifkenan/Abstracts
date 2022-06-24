using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilya
{
    internal class Kanepe:Mobilya
    {
        public int ayaksayisi { get; set; }
        public string malzeme { get; set; }
        public string kumasrengi { get; set; }
        public bool bazalimi { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("kanepenin özellikleri");
            Console.WriteLine("malzeme " + malzeme);
            Console.WriteLine("ayak sayisi " + ayaksayisi);
            Console.WriteLine("kumasrengi" + kumasrengi);
            Console.WriteLine("bazali mi"+bazalimi);
        }
    }
}
