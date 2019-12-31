using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeManagement.Managers;
using TraineeManagement.NewFolder1;

namespace TraineeManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

            int choice_menu = 0;
            do
            {
                Console.Write("Donnez votre choix : ");
                try
                {
                    choice_menu = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Veuillez entrer un choix valide ");
                    break;
                }

                switch (choice_menu)
                {
                    case 1:
                        GroupUI.Add();
                        break;
                    case 2:
                        GroupUI.ShowAll();
                        break;

                    default:
                        break;
                }

            } while (choice_menu != 1000);

            Console.WriteLine("Merci pour l'utilisation de notre application ");
            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine(" \t \t Gestion des stagiaires");
            Console.WriteLine(" \t Gestion des groupes");
            Console.WriteLine("1- Ajouter un groupe");
            Console.WriteLine("2- Afficher les groupes");
            Console.WriteLine(" \t Gestion des stagiaires");
            Console.WriteLine("10- Ajouter un stagiaire");
            Console.WriteLine("11- Afficher les stagiaires");
            Console.WriteLine("1000- Quiter");
        }


    }
}
