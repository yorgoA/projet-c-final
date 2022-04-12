using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp
{
    public class ParentBank
    {
        private string? nom;
        private string? address;
        private List<Utilisateur> utilisateurs = new List<Utilisateur>();

        public ParentBank() { }
        public ParentBank(string n, string address, List<Utilisateur> utilisateurs) { 
            this.nom = n;
            this.address = address; 
            this.utilisateurs.AddRange(utilisateurs);   
        }
        public string? Nom   
        {
            get => nom; 
            set { nom = value; }
        }
        public string? Address
        {
            get => address;
            set { address = value; }
        }
        public List<Utilisateur> Utilisateurs { 
            get { return utilisateurs; }
            set { utilisateurs = value; }
        }

        public override string? ToString()
        {
            return base.ToString();
        }

    }
}
