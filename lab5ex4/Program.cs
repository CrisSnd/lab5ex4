using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit de la tastatura, ignorand caseing-ul literelor.*/


            Console.WriteLine("Introduceti sirul de caractere: ");
            string text = Console.ReadLine();

            Console.WriteLine(NumaraLitere(text.ToLower()));
        }



        static string NumaraLitere(string text1)
        {
            int[] litera = new int[255];
            int max = 0;
            char contorLitere = ' ';

            for (int i = 0; i < text1.Length; i++)
            {
                litera[text1[i]]++;
                if (max < litera[text1[i]])
                {
                    max = litera[text1[i]];
                    contorLitere = text1[i];
                }
            }

            var rezultat = $"Litera {contorLitere} apare de {max} ori";
            return rezultat;    
        } 
    }

}