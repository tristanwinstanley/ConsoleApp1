using System;
using System.Collections.Generic;
using System.Text;

namespace ExoHeritage
{
    internal class Panier
    {
        private List<Instrument> instruments;
        public string NomClient
        {
            get
            {
                return NomClient.ToLower();
            }
            set
            {
                NomClient = value;
            }
        }
        public Panier()
        {
        }
        public void AjouterInstruments()
        {
            instruments.Add(new Piano());
            instruments.Add(new Piano());
            instruments.Add(new Guitare());
        }
        public int CalculerPrixDuPanier()
        {
            int total = 0;
            int prixMini = 0;

            foreach (Instrument instrument in instruments)
            {
                int prix = instrument.Prix;

                total += prix;

                if (prix < prixMini)
                {
                    prixMini = prix;
                }
            }

            if (instruments.Count >= 3)
            {
                total = total - prixMini;
            }

            return total;
        }
    }
}
