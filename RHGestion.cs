namespace ConsoleApp1
{
    public class RHGestion
    {
        private List<Employe> _employes;
        private GestionnaireDePaie _managerDePaie;
        private GestionnaireDePromotion _gestionnaireDePromotion;
        public RHGestion()
        {
            _employes = new List<Employe>();
            _managerDePaie = new GestionnaireDePaie();
            _gestionnaireDePromotion = new GestionnaireDePromotion();
        }
        public void FinDeMois()
        {
            foreach (Employe employe in _employes)
            {
                _managerDePaie.PayerEmploye(employe);
            }
        }
        public void AjouterNouvelEmploye(Employe employe)
        {
            _employes.Add(employe);
        }
        public void PromouvoirEmploye(string nom, int typeDePromotion)
        {
            Employe? employeAPromouvoir = null;
            foreach (Employe employe in _employes)
            {
                if (employe.Nom == nom)
                {
                    employeAPromouvoir = employe;
                    break;
                }
            }
            if (employeAPromouvoir != null)
                _gestionnaireDePromotion.Promotion(employeAPromouvoir, typeDePromotion);
        }
        public void MontrerEmployes()
        {
            foreach (Employe employe in _employes)
            {
                Console.WriteLine(employe.GetDescription());
            }
        }
    }
}