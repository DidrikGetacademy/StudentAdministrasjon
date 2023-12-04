using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Fag
    {
      
        public int FagKode { get; set; }
        public string FagNavn { get; set; }
        public int AntallStudiePoeng { get; set; }




        public Fag(int SubjectNr, string SubjectClass, int studiePoeng)
        {
            FagKode = SubjectNr;
            FagNavn = SubjectClass;
            AntallStudiePoeng = studiePoeng;
        }


        
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagnavn: {FagNavn}, " +
                              $"Fagkode: {FagKode}, " +
                              $"Studiepoeng: {AntallStudiePoeng}");
        }


    }
}


