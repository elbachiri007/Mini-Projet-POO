using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeManagement.Entities;
using TraineeManagement.Managers;

namespace TraineeManagement.NewFolder1
{
    public static class GroupUI
    {
        public static void Add()
        {
            // Saisie 
            Console.WriteLine("Saisie du groupe");
            Console.Write("Nom :");
            string name = Console.ReadLine();

            // Creation de l'instance 
            Group g = new Group();
            g.Name = name;

            // Add to Manager
            GroupManager gm = new GroupManager();
            gm.Add(g);
        }

        public static void ShowAll()
        {
            GroupManager gm = new GroupManager();
            foreach (Group item in gm.FindAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
