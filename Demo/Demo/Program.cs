using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // En utilisant la syntaxe du langage C
            // Créer une boucle pour afficher la table des 8 (multiplication).
            // Concaténer : +
            // Saut de ligne : \n
            const int multiple = 8;
            const int valMax = 10;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string affichage = "";
            for (int i =0; i <=valMax; i++)
            {
                // interpolated string (C# >= v6)
                int resultat = multiple * i;
                affichage +=
                    $"{i:00} x {multiple,4} = {resultat,10:C}";
                 
                affichage += "\n";
            }
            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
