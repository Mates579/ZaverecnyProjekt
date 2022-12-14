using ZaverecnyProjekt;

List<Pojistenci> pojistenci = new();
char volba;
do
{
    //Vymazání a vypsání úvodní obrazovky
    Console.Clear();
    Console.WriteLine("------------------------------");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("------------------------------");
    Console.WriteLine();
    //Vypsání možností akcí
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěnce");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");

    //Načtení volby od uživatele
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (volba)
    {
        //Přidání nového pojištěnce
        case '1':
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Poviná položka. Zadejte jméno pojištěného:");
            }
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Poviná položka. Zadejte příjmení pojištěného:");
            }
            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            string telefon;
            while (string.IsNullOrWhiteSpace(telefon = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Poviná položka. Zadejte telefonní číslo pojištěného:");
            }
            Console.WriteLine("Zadejte datum narození:");
            //Kontrola zadání data narození
            DateOnly datumNarozeni;
            while (!DateOnly.TryParse(Console.ReadLine(), out datumNarozeni))
                Console.WriteLine("Neplatné datum, zadejte prosím znovu.");
            pojistenci.Add(new Pojistenci(jmeno, prijmeni, datumNarozeni, telefon));
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            break;

        //Vypsání všech pojištěnců
        case '2':
            if (pojistenci.Any())
            {
                foreach (Pojistenci p in pojistenci)
                {
                    Console.WriteLine(p);
                }
            }
            else Console.WriteLine("Zatím nebyli přidáni žádní pojištěnci.");
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            break;

        //Vyhledání pojištěnce
        case '3':
            Console.WriteLine("Zadejte hledané jméno pojištěného:");
            string jmenoHledani;
            while (string.IsNullOrWhiteSpace(jmenoHledani = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Poviná položka. Zadejte hledané jméno pojištěného:");
            }
            Console.WriteLine("Zadejte hledané přijmení pojištěného:");
            string prijmeniHledani;
            while (string.IsNullOrWhiteSpace(prijmeniHledani = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Poviná položka. Zadejte hledané přijmení pojištěného:");
            }
            var hledani = from p in pojistenci
                          where (p.Jmeno == jmenoHledani) && (p.Prijmeni == prijmeniHledani)
                          select p;

            if (hledani.Any())
            {

                foreach (var v in hledani)
                    Console.WriteLine(v);
            }
            else Console.WriteLine("Vašemu dotazu neodpovídají žádní pojištěnci.");
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            break;

        //Ukončení aplikace
        case '4':
            Console.WriteLine("Děkuji za použití programu.\nProgram ukončíte libovolnou klávesou.");
            break;
        default:
            Console.WriteLine("Neplatná volba, pokračujte libovolnou klávesou.");
            Console.ReadKey();
            break;
    }
} while (volba != 4);