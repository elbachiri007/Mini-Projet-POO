using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_Objet
{
    public class Personne
    {
        private long id;
        public long Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Personne() {
            this.DateNaissance = DateTime.Now;
        }
        public Personne(string Nom)
        {
            this.Nom = Nom;
            this.DateNaissance = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Personne : [{this.id},{this.Nom},{this.DateNaissance}]";
        }
        public override bool Equals(object obj)
        {
            Personne personne = obj as Personne;
            if (personne.id == this.id) return true;
            return false;
        }

    }
}
