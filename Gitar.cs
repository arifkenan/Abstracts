using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    internal abstract class Gitar : MuzikAleti
    {
        public override string Cal()
        {
            return "Gitar caldi";
        }
        public abstract void AkordEt();
        
    }
}
