using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp
{
    public class BankOnline : ParentBank
    {
        public BankOnline() { }
        public BankOnline(string n, string address, List<Utilisateur> utilisateurs) : base(n, address, utilisateurs)
        {
        }
    }
}
