using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 3
            var klasserum = new KlasseRum();
            klasserum.KlasseNavn = "Zealand-3";
            klasserum.SemesterStart = new DateTime(2019, 1, 1);
            klasserum.Klasseliste.Add(new studerende("Hans", 5, 7));
            klasserum.Klasseliste.Add(new studerende("Grete", 3, 20));
            klasserum.Klasseliste.Add(new studerende("Bo", 10, 1));



        }
    }
}
