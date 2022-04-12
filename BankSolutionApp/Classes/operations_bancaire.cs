using BankSolutionApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp
{
    public class operations_bancaire: IOperationBancairecs
    {

        private string? type_operation;
        private DateTime? date_operation;

        public operations_bancaire() { }
        public operations_bancaire(string typeop,DateTime dt) { 
            this.type_operation = typeop;   
            this.date_operation = dt;   
        }
        public string? TypeOperation
        {
            get => type_operation;
            set => type_operation = value;
        }

        public DateTime? DateOperation
        {
            get => date_operation;
            set => date_operation = value;
        }

        public decimal Retrait(decimal? solde, decimal? somme)
        {

            if (solde < 0) throw new SoldeNegException("votre solde est Negatif!");
            else
                return (decimal)(solde - somme);

        }
        public decimal Crediter(decimal? solde, decimal? somme) => (decimal)(solde + somme);

        public string AfficherInfo(Utilisateur utilisateur)
        {

            return utilisateur.Nom + " votre compte est de:" + utilisateur.Solde;

        }

        public string HistoriqueDesOperation(Utilisateur utilisateur)
        {
            string retString = string.Empty;

            foreach (operations_bancaire item in utilisateur.operations_Bancaires)
            {

                retString += "Operation:" + item.type_operation + " - Date:" + item.date_operation + "\n\r";

            }
            return retString;
        }

        public override string? ToString()
        {
            return base.ToString();
        }

    }
}
