using BankSolutionApp;
String cr = "Credit";
String dr = "Debit";
BankPhysique LaPoste = new BankPhysique();
BankOnline Boursorama = new BankOnline();
GestionnaireBank GestionnaireBank = new GestionnaireBank();
Utilisateur utilisateurRamy = new Utilisateur("Ramy","Dupon",10,new List<operations_bancaire>());
Utilisateur utilisateurJean = new Utilisateur("Jean","Dupon",20,new List<operations_bancaire>());
Utilisateur utilisateurJack = new Utilisateur("Jack","Dupon",30,new List<operations_bancaire>());
Utilisateur utilisateurFrancois = new Utilisateur("Francois","Dupon",20,new List<operations_bancaire>());
Utilisateur utilisateurRoger = new Utilisateur("Roger","Dupon",50,new List<operations_bancaire>());
Utilisateur utilisateurRose = new Utilisateur("Rose","Dupon",200,new List<operations_bancaire>());

LaPoste =(BankPhysique) GestionnaireBank.addUtilisateurToBank(utilisateurRamy, LaPoste);
LaPoste = (BankPhysique)GestionnaireBank.addUtilisateurToBank(utilisateurJean, LaPoste);
LaPoste = (BankPhysique)GestionnaireBank.addUtilisateurToBank(utilisateurJack, LaPoste);
Boursorama = (BankOnline)GestionnaireBank.addUtilisateurToBank(utilisateurFrancois, Boursorama);
Boursorama = (BankOnline)GestionnaireBank.addUtilisateurToBank(utilisateurRoger, Boursorama);
Boursorama = (BankOnline)GestionnaireBank.addUtilisateurToBank(utilisateurRose, Boursorama);



operations_bancaire Operation = new operations_bancaire();
operations_bancaire OperationCrRamy = new operations_bancaire(cr,DateTime.Now);
operations_bancaire OperationDrRamy = new operations_bancaire(dr, DateTime.Now);
utilisateurRamy.Solde = Operation.Crediter(utilisateurRamy.Solde, 10);
utilisateurRamy.Solde = Operation.Retrait(utilisateurRamy.Solde, -10);
utilisateurRamy.operations_Bancaires.Add(OperationCrRamy);
utilisateurRamy.operations_Bancaires.Add(OperationDrRamy);
Console.WriteLine(Operation.HistoriqueDesOperation(utilisateurRamy));

operations_bancaire OperationCrJean = new operations_bancaire(cr, DateTime.Now);
operations_bancaire OperationDrJean = new operations_bancaire(dr, DateTime.Now);
utilisateurJean.Solde = Operation.Crediter(utilisateurJean.Solde, 3);
utilisateurJean.Solde = Operation.Retrait(utilisateurJean.Solde, -1);
utilisateurJean.operations_Bancaires.Add(OperationCrJean);
utilisateurJean.operations_Bancaires.Add(OperationDrJean);
Console.WriteLine(Operation.AfficherInfo(utilisateurJean));



operations_bancaire OperationCrJack = new operations_bancaire(cr, DateTime.Now);
operations_bancaire OperationDrJack = new operations_bancaire(dr, DateTime.Now);
utilisateurJack.Solde = Operation.Crediter(utilisateurJack.Solde, 50);
utilisateurJack.Solde = Operation.Retrait(utilisateurJack.Solde, (decimal?) -1.3);
utilisateurJack.operations_Bancaires.Add(OperationCrJack);
utilisateurJack.operations_Bancaires.Add(OperationDrJack);
Console.WriteLine(Operation.AfficherInfo(utilisateurJack));


operations_bancaire OperationCrFrancois = new operations_bancaire(cr, DateTime.Now);
operations_bancaire OperationDrFrancois = new operations_bancaire(dr, DateTime.Now);
utilisateurFrancois.Solde = Operation.Crediter(utilisateurFrancois.Solde, 100);
utilisateurFrancois.Solde = Operation.Retrait(utilisateurFrancois.Solde, (decimal?)-40.03);
utilisateurFrancois.operations_Bancaires.Add(OperationCrFrancois);
utilisateurFrancois.operations_Bancaires.Add(OperationDrFrancois);
Console.WriteLine(Operation.AfficherInfo(utilisateurFrancois));




operations_bancaire OperationCrRoger = new operations_bancaire(cr, DateTime.Now);
operations_bancaire OperationDrRoger = new operations_bancaire(dr, DateTime.Now);
utilisateurRoger.Solde = Operation.Crediter(utilisateurRoger.Solde, 90);
utilisateurRoger.Solde = Operation.Retrait(utilisateurRoger.Solde, (decimal?)-20.03);
utilisateurRoger.operations_Bancaires.Add(OperationCrRoger);
utilisateurRoger.operations_Bancaires.Add(OperationDrRoger);
Console.WriteLine(Operation.AfficherInfo(utilisateurRoger));



operations_bancaire OperationCrRose = new operations_bancaire(cr, DateTime.Now);
operations_bancaire OperationDrRose = new operations_bancaire(dr, DateTime.Now);
utilisateurRose.Solde = Operation.Crediter(utilisateurRose.Solde, 90);
utilisateurRose.Solde = Operation.Retrait(utilisateurRose.Solde, (decimal?)-20.03);
utilisateurRose.operations_Bancaires.Add(OperationCrRose);
utilisateurRose.operations_Bancaires.Add(OperationDrRose);
Console.WriteLine(Operation.AfficherInfo(utilisateurRose));
