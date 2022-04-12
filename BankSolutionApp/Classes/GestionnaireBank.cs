using BankSolutionApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp
{
    public class GestionnaireBank : IGestionBancaire
    {
        public Utilisateur addOperationBancaire(Utilisateur utilisateur, operations_bancaire operations_Bancaire)
        {
            utilisateur.operations_Bancaires.Add(operations_Bancaire);
            return utilisateur;
        }

        public ParentBank addUtilisateurToBank(Utilisateur utilisateur, ParentBank parentBank)
        {
            parentBank.Utilisateurs.Add(utilisateur);
            return parentBank;
        }

        public string GetUtilisateurBank(ParentBank bank)
        {
            string retStr = string.Empty;
            string? banknom = bank.Nom;
            if (bank.Utilisateurs.Count == 0) { return "La bank:" + banknom + " a aucun utilisateur"; }
            retStr += "Les utilisateurs de la bank " + banknom + " sont:";
            foreach (Utilisateur item in bank.Utilisateurs)
            {
                retStr += item.Nom + "\n\r";
            }
            return retStr;
        }

        public string GetUtilisateurOperationbancaire(Utilisateur utilisateur)
        {
            string retStr=string.Empty;
            string nomConcat = string.Concat(utilisateur.Nom, " ", utilisateur.Prenom);
            if (utilisateur.operations_Bancaires.Count() == 0) { return "L'utilisateur " + nomConcat + " n'a aucune operation."; }

            retStr += "Les Operation bancaire de " + nomConcat + " sont:";

            foreach (operations_bancaire item in utilisateur.operations_Bancaires)
            {
                retStr +=item.DateOperation + ":" + item.TypeOperation + "\n\r";
            }
            return retStr;
        }
    }
}
