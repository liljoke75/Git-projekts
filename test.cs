using System;
                    
public class Program
{
    public static void Main()
    {
        string[] Aboli = {"Latvijas Abols", "Ukrainas Abols", "Krievijas abols"};
            string[] Ogas = {"Zemene", "Avene", "Ķirsis"};

            foreach(string abols in Aboli) {
                foreach(string oga in Ogas){
                    string Ievarijums = abols + " un " + oga + " Ievarijums";
                    System.Console.WriteLine(Ievarijums);
                }
            }
    }
}