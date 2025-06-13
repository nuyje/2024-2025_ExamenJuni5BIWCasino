namespace ExamenJuniBIW_Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        //Deze methode is gegeven. Verander niets aan deze methode. 
        public static void CasinoLoop()
        {
            int keuze = 0;
            int geld = 0;
            while (keuze != 4)
            {

                Console.WriteLine($"Je hebt {geld} euro.");
                keuze = ToonMenu();

                switch (keuze)
                {
                    case 1:
                        geld += RaadHetGetal();
                        break;
                    case 2:
                        geld += RekenenMaar();
                        break;
                    case 3:
                        geld += ArrayGame();
                        break;
                    default:
                        //ShowEnding(geld);
                        keuze = -1;
                        break;

                }
                Console.WriteLine("Druk toets om verder te gaan");
                Console.ReadKey();
            }
        }

        //Deze methode is gegeven. Zoals je in de opgave kan lezen moet je aan deze methode wel een aanpassing doen. 
        public static int ToonMenu()
        {
            int keuze = 0;
            
            do
            {
                Console.WriteLine("Geef keuze");
                Console.WriteLine("\t1. Raad het getal");
                Console.WriteLine("\t2. Rekenen maar");
                Console.WriteLine("\t3. Raad de sequentie");
                Console.WriteLine("\t4. Stop");
                Console.Write("Keuze: ");
                keuze = Convert.ToInt32(Console.ReadLine());

            } while (keuze != 1 && keuze != 2 && keuze != 3 && keuze != 4);

            return keuze;
        }
    }
}
