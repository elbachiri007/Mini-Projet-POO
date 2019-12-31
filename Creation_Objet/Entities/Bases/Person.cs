using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeManagement.Entities
{
    public abstract class Person : BaseEntity
    {

        public String FirstName { get; set; }
        public String LasteName { get; set; }
        public DateTime BirthDay { get; set; }

        public override string ToString()
        {
            return $"Personne : [{this.Id},{this.FirstName},{this.LasteName}]";
        }

    }
}
