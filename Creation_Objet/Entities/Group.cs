using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeManagement.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Groupe : {this.Id}-{this.Name}";
        }
    }
}
