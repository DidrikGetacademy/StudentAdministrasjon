using System.Diagnostics;

namespace StudentAdministrasjonsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // ny student fra klassen
            Student student1 = new Student("Didrik", "Programmering", 23, 1);
            Student student2 = new Student("Hilde", "Biologi", 23, 2);
       
            

            //forskjellige fag 
            List<Fag> fagListe = new List<Fag>();
            Fag fag3 = new Fag(105, "Matematikk", 6);
            Fag fag4 = new Fag(108, "Historie", 4);
            Fag fag5 = new Fag(110, "Engelsk", 8);
            Fag nyttFag = new Fag(103, "Programmering", 5);
            Fag nyttFag2 = new Fag(101, "biologi", 4);
            fagListe.Add(fag3);
            fagListe.Add(fag4);
            fagListe.Add(fag5);
            fagListe.Add(nyttFag);
            fagListe.Add(nyttFag2);
            


            //liste til fagene studentene tar 
            student1.FageneStudentenTar = new List<Fag> { fag3, fag5, fag4 };
            student2.FageneStudentenTar = new List<Fag> { fag4, nyttFag2, nyttFag };

    


            //legger til karakter 
            student1.LeggtilKarakter(fag3, "A");
            student1.LeggtilKarakter(fag5, "C");
            student1.LeggtilKarakter(fag4, "A");
            student2.LeggtilKarakter(fag4, "A");
            student2.LeggtilKarakter(nyttFag2, "C");
            student2.LeggtilKarakter(nyttFag, "B");










            bool programRunning = true;
            while (programRunning)
            {
                Console.WriteLine("1.Informasjon studenter");
                Console.WriteLine("2. informasjon om fagene til studentene");
                Console.WriteLine("3. se karakter til studentene");
                Console.WriteLine("4. totalt antall studiepoeng til studentene");
                Console.WriteLine("5. exit program");
                var userinput = Console.ReadLine();


                switch (userinput)
            {



                case "1":
                    student1.SkrivUtInfo();
                    student2.SkrivUtInfo();
                    break;



                case "2":
                    foreach (var student in new[] { student1, student2 })

                    {
                        Console.WriteLine();
                        Console.WriteLine($"informasjon om fagene for {student.Navn}");
                        Console.WriteLine(".......................................");



                        foreach (var fag in student.FageneStudentenTar)
                        {
                            fag.SkrivUtInfo();
                        }
                    }
                    break;


                case "3":
                    foreach (var student in new[] { student1, student2 })
                    {
                       
                        Console.WriteLine($"Karakter informasjon for {student.Navn}");
                     

                            Console.WriteLine(".......................................");
                        foreach (var karakter in student.Karakterer)
                        {
                            
                                karakter.SkrivUtInfo();
                        }
                        student.gjennomsnittkarakter();
                        Console.WriteLine();
                      
                    }
                    break;

                case "4":
                    foreach (var student in new[] { student1, student2 })
                    {
                        Console.WriteLine($"Totalt antall studiepoeng for {student.Navn}: {student.TotalStudyPoints()}");

                    }
                    break;


                case "5":
                    programRunning = false;
                    break;


                    

                }
                Console.WriteLine();

            }
        }
    }
}


