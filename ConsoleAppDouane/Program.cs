namespace ConsoleAppDouane
{
    internal class Program
    {
        static void Main(string[] args)

        {
            const decimal tauxDouane = 0.20m;
            const decimal tauxDouaneNain = 0.10m;
            const decimal tauxDouaneContrebandier = 0.055m;
            const decimal tauxDouaneTemple = 0.021m;

            Console.WriteLine("Saisir le prix de l'arme en pièces d'or");
            string arme = Console.ReadLine();
            Console.WriteLine("Choisissez la zone de provenance de la forge");
            Console.WriteLine("1 - Forges de la Capitale (20%)");
            Console.WriteLine("2 - Ateliers des Nains des Montagnes (10%)");
            Console.WriteLine("3 - Ports des contrebandiers (5,5%)");
            Console.WriteLine("4 - Terres Sacrées du Temple (2,1%)");

            if (int.TryParse(Console.ReadLine(), out int zone))
            {
                double prix = double.Parse(arme);
                double taxe = 0;
                switch (zone)
                {
                    case 1:
                        taxe = prix * (double)tauxDouane;
                        break;
                    case 2:
                        taxe = prix * (double)tauxDouaneNain;
                        break;
                    case 3:
                        taxe = prix * (double)tauxDouaneContrebandier;
                        break;
                    case 4:
                        taxe = prix * (double)tauxDouaneTemple;
                        break;
                    default:
                        Console.WriteLine("Zone invalide.");
                        return;
                }
                double total = prix + taxe;
                Console.WriteLine($"Prix de l'arme : {prix} pièces d'or");
                Console.WriteLine($"Taxe douanière : {taxe} pièces d'or");
                Console.WriteLine($"Prix total à payer : {total} pièces d'or");
            }
            else
            {
                Console.WriteLine("Entrée invalide pour le prix de l'arme.");
            }



        }
    }
}
