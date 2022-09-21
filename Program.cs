namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            System.Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2000);
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("Seja bem vindo ao Stopwatch!\n");
            System.Console.WriteLine("S - Segundos / Seconds");
            System.Console.WriteLine("M - Minutos / Minutes");
            System.Console.WriteLine("C - Como usar? / How to use?");
            System.Console.WriteLine("0 - Sair / Quit\n");
            System.Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower(); //Faz conversão diretamente da string para lowercase
            if (data == "c")
                HowToUse();
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //Pega parte da cadeia de char
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);
            Start(time * multiplier);
        }

        static void HowToUse()
        {
            Console.Clear();
            char decisionUser;
            System.Console.WriteLine("===== PT-BR =====\n");
            System.Console.WriteLine("• Para contar somente os SEGUNDOS, usa-se o formato: 10s, 30s, 24s e etc.");
            System.Console.WriteLine("• E para contar os MINUTOS, usa-se o formato: 1m, 3m, 10m e etc.\n");
            System.Console.WriteLine("===== EN =====\n");
            System.Console.WriteLine("• To count only the SECONDS, use the format: 10s, 30s, 24s, etc.");
            System.Console.WriteLine("• And to count the minutes, use the format: 1m, 3m, 10m and etc.\n");
            System.Console.WriteLine("[X] Para voltar ao menu / Go to menu");
            System.Console.WriteLine("[Q] Para sair da aplicação / Exit the application\n");
            decisionUser = char.Parse(Console.ReadLine());
            switch (decisionUser)
            {
                case 'x': case 'X': Menu(); break;
                case 'q': case 'Q': System.Environment.Exit(0); break;
                default: Console.Clear(); System.Console.WriteLine("Opção inválida! Retornando a página anterior.\n"); System.Console.WriteLine("Invalid option! Returning to the previous page."); Thread.Sleep(2000); HowToUse(); break;
            }
        }
    }
}