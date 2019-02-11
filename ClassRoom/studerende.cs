using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class studerende
    {
        public string Navn { get; set; }

        public int FødselsMåned { get; set; }

        public int FødselsDag { get; set; }

        public studerende(string navn, int måned, int dag)
        {
            Navn = navn;
            FødselsMåned = måned;
            FødselsDag = dag;

        }

    }
}
