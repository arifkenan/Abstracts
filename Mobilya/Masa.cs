using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.Mobilya
{
    internal class Masa:Mobilya
    {
        public int ayaksayisi { get; set; }
        public string malzeme { get; set; }
        public int cekmecesayisi { get; set; }

        public override void OzellikleriYaz()
        {
            Console.WriteLine("mobilyanın özellikleri");
            Console.WriteLine("malzeme "+ malzeme);
            Console.WriteLine("ayak sayisi "+ ayaksayisi);
            Console.WriteLine("cekmece sayisi"+ cekmecesayisi);
        }
    }
}
