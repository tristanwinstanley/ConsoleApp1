
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Ajouter employe");
                Console.WriteLine("2. Promouvoir employe");
                Console.WriteLine("3. Lister les employes");
                Console.WriteLine("4. Avancer d'1 mois");
                Console.WriteLine("5. Fin");

                var instruction = Console.ReadLine();

                RHGestion rhGestion = new();
                switch (instruction)
                {
                    case "1":
                        Console.WriteLine("Comment s'appelle l'employe?");
                        var nom = Console.ReadLine();
                        Console.WriteLine("Quel poste occupe l'employe?");
                        var poste = Console.ReadLine();
                        Console.WriteLine("Quel est le salaire de l'employe?");
                        var salaireString = Console.ReadLine();
                        var salaire = int.Parse(salaireString);
                        Employe employe = new(nom, poste, salaire);
                        rhGestion.AjouterNouvelEmploye(employe);
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Nom de l'employe a promouvoir:");
                        var employeAPromouvoir = Console.ReadLine();
                        Console.WriteLine("Type de promotion?");
                        var typeDePromotion = int.Parse(Console.ReadLine());
                        rhGestion.PromouvoirEmploye(employeAPromouvoir, typeDePromotion);
                        Console.Clear();
                        break;

                    case "3":
                        //
                        break;


                    case "4":
                        //
                        break;
                }
            }
        }
    }
}