using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_2
{
    class Client
    {
        private string Nom;
        private string Prénom;
        private string Adresse;

        public Client(string n, string p, string a)
        {
            this.Nom = n;
            this.Prénom = p;
            this.Adresse = a;
        }
        public void Afficher()
        {
            Console.WriteLine("Le nom est : " + this.Nom);
            Console.WriteLine("Le prénom est : " + this.Prénom);
            Console.WriteLine("L'adress est : " + this.Adresse);
        }

    }
}
