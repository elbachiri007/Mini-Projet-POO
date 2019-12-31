using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeManagement.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public override bool Equals(object obj)
        {
            var baseentity = obj as BaseEntity;
            if (this.Id == baseentity.Id) return true;
            return false;
        }

    }
}
