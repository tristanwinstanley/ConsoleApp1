namespace ConsoleApp1
{
    public class Employe(string nom, string poste, int salaire)
    {
        public string Nom { get; private set; } = nom;
        public string Poste { get; private set; } = poste;
        public int Salaire { get; private set; } = salaire;
        public int Rang { get; private set; } = 1;
        public DateTime DateDeDebut { get; private set; } = DateTime.Now;
        public int BonPoint { get; private set; }

        public string GetDescription()
        {
            return $"Employe {Nom}, occupant le poste de {Poste} et touchant un salaire annuel de {Salaire} depuis le {DateDeDebut}";
        }
        public void ChangerSalaire(int nouveauMontant)
        {
            Salaire = nouveauMontant;
        }
        public void ChangerRang(int nombreDeRangs = 1)
        {
            Rang += nombreDeRangs;
        }
    }
}
