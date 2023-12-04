using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Karakter
    {
        public Student Student { get; set; } 
        public Fag Fag { get; set; }
        public string KarakterVerdi { get; set; }


        public Karakter(Student student, Fag fag,string karakterVerdi)
        {
            Student = student;
            Fag = fag;
            KarakterVerdi = karakterVerdi;

        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($" StudieFag: {Fag.FagNavn}, Karakter: {KarakterVerdi}");

        }

    }
}

