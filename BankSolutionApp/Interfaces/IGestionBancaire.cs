using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp.Interfaces
{
    public interface IGestionBancaire
    {

        public ParentBank addUtilisateurToBank(Utilisateur utilisateur, ParentBank parentBank);
        public Utilisateur addOperationBancaire(Utilisateur utilisateur,operations_bancaire operations_Bancaire);

        public string GetUtilisateurOperationbancaire(Utilisateur utilisateur);
        public string GetUtilisateurBank(ParentBank bank);

    }
}
