class Program
{
    static void Main(string[] args)
    {
        bool continueLoop = true;
        Logger logger = Logger.GetInstance();

        while (continueLoop)
        {
            DisplayMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("\nPodaj treść: ");
                    logger.LogMessage(Console.ReadLine());
                    break;
                case "2":
                    logger.DisplayLog();
                    break;
                case "3":
                    continueLoop = false;
                    break;
                default:
                    Console.WriteLine("\nZły numer!");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\n1. Nowy log");
        Console.WriteLine("2. Wyświetl wszystkie logi");
        Console.WriteLine("3. Zakończ program");
        Console.Write("Wybierz numer: ");
    }
}
