using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSolutionApp.Interfaces
{
    public interface IOperationBancairecs
    {
        public decimal Retrait(decimal? solde, decimal? somme);

        public decimal Crediter(decimal? solde, decimal? somme);
        public string AfficherInfo(Utilisateur utilisateur);
        public string HistoriqueDesOperation(Utilisateur utilisateur);

    }
}
