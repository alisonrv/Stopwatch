// See https://aka.ms/new-console-template for more information
namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Start(30);
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
            System.Console.WriteLine("S - Segundos");
            System.Console.WriteLine("M - Minutos");
            System.Console.WriteLine("0 - Sair\n");
            System.Console.WriteLine("Quanto tempo deseja contar?");
        }
    }
}