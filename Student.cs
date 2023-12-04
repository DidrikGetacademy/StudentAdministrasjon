using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic.CompilerServices;
using StudentAdministrasjonsSystem;

internal class Student
{

    public string Navn { get; set; }
    public int Alder { get; set; }
    public int StudentID { get; set; }
    public string Studieprogram { get; set; }

    public List<Fag> FageneStudentenTar { get; set; }
    public List<Karakter> Karakterer { get; set; }




    public Student(string navn, string studieProgram, int alder, int studentID)
    {
        Navn = navn;
        Alder = alder;
        StudentID = studentID;
        Studieprogram = studieProgram;
        Karakterer = new List<Karakter>();
    }

    public void SkrivUtInfo()
    {
       
        Console.WriteLine($"Navn: {Navn} Alder: {Alder}, StudentID: {StudentID}  Studieprogram: {Studieprogram}");
    }

    public void LeggtilKarakter(Fag fag, string Karakterverdi)
    {
        Karakterer.Add(new Karakter(this, fag, Karakterverdi));
    }





    public void gjennomsnittkarakter()
    {
        if (Karakterer.Count == 0)
        {
            Console.WriteLine($"{Navn} har ingen karakter ennå");
            return;
        }

        double totalkarakterVerdi = 0.0;
        foreach (var karakter in Karakterer)
        {
            int karakterVerdi = karakter.KarakterVerdi[0] - 'A' + 1;
            totalkarakterVerdi += karakterVerdi;
        }

        double gjennomsnitt = totalkarakterVerdi / Karakterer.Count;

        char gjennomsnittKarakter = (char)('A' + (int)gjennomsnitt - 1);
        Console.WriteLine($" {Navn} gjennomsnittkarakter: {gjennomsnittKarakter}");

    }



    public int TotalStudyPoints()
    {
        int totalstudiepoeng = 0;
        foreach (var fag in FageneStudentenTar)
        {
            totalstudiepoeng += fag.AntallStudiePoeng;
        }
        return totalstudiepoeng;
    }
}

