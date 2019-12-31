using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeManagement.Entities;

namespace TraineeManagement.Managers
{
    public class Manager<T> where T:BaseEntity
    {
        private static int Compteur;
        private static List<T> List = new List<T>();

        public void Add(T entity)
        {
            entity.Id = ++Compteur;
            List.Add(entity);
        }

        public List<T> FindAll()
        {
            return List;
        }
    }

}
