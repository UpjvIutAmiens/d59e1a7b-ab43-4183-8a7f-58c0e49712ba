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
                affichage += 
                    string.Format("{0:00} x {1,-4} = {2,10:C}",
                    i,              // Element : 0
                    multiple,       // Element : 1
                    multiple * i    // Element : 2
                    );
                 
                affichage += "\n";
            }
            Console.WriteLine(affichage);
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
