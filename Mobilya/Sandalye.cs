using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilya
{
    internal class Sandalye:Mobilya
    {
        public int ayaksayisi { get; set; }
        public string malzeme { get; set; }
        public int renk { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("masanın özellikleri");
            Console.WriteLine("malzeme " + malzeme);
            Console.WriteLine("ayak sayisi " + ayaksayisi);
            Console.WriteLine("renk" + renk);
        }
    }
}
