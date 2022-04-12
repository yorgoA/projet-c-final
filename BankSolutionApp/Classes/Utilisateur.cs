using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp
{
    public class Utilisateur
    {
        private string? nom;
        private string? prenom;
        private decimal? solde;

        public Utilisateur(string n,string p,decimal s,List<operations_bancaire> op) {
            this.nom = n;
            this.prenom = p;
            this.solde = s;
            this.operations_Bancaires = op;
        }

        public string? Nom
        {
            get => nom;
            set { nom = value; }
        }
        public string? Prenom
        {
            get => prenom;
            set { prenom = value; }
        }
        public decimal? Solde
        {
            get => solde;
            set { solde = value; }
        }

        public List<operations_bancaire>? operations_Bancaires { get; set; } = null;

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
