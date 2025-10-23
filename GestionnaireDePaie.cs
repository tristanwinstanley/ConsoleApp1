namespace ConsoleApp1
{
    public class GestionnaireDePaie : IGestionnaireDePaie
    {
        readonly int _montantBonus = 500;
        private FileLogger logger = new();
        public void PayerEmploye(Employe employe)
        {
            decimal paieMensuelleInitiale = employe.Salaire / 12;
            decimal paieMensuelleFinale = paieMensuelleInitiale + _montantBonus * employe.BonPoint;
            EffectuerVirement(employe, paieMensuelleFinale);
        }
        private void EffectuerVirement(Employe employe, decimal paieMensuelleFinale)
        {
            // Logique complexe pour effectuer virement
            logger.Log($"virement effectué vers employe {employe}");
        }
    }
    public class FileLogger
    {
        public void Log(string x)
        {
            
        }
    }
}