namespace ConsoleApp1
{
   public class GestionnaireDePromotion : IGestionnaireDePromotion
    {
        readonly int _montantPromotionBasse = 2000;
        readonly int _montantPromotionMoyenne = 4000;
        readonly int _montantPromotionHaute = 10000;
        public void Promotion(Employe employe, int typeDePromotion)
        {
            if (typeDePromotion == 1)
            {
                employe.ChangerSalaire(_montantPromotionBasse);
                employe.ChangerRang(1);
            }
            else if (typeDePromotion == 2)
            {
                employe.ChangerSalaire(_montantPromotionMoyenne);
                employe.ChangerRang(2);
            } 
            else if (typeDePromotion == 3)
            {
                employe.ChangerSalaire(_montantPromotionHaute);
                employe.ChangerRang(3); 
            } 
        }
    } 
}
