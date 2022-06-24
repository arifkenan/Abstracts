using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public abstract class MuzikAleti
    {
        public string Marka { get; set; }
        public string Aciklama { get; set; }

        public abstract string Cal();
    }
}
