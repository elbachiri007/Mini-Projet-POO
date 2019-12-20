using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne;
            personne = new Personne();

            Personne p2 = new Personne("Madani");

            Console.WriteLine(personne);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }
}
