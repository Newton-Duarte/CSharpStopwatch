using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("Escolha uma opção:");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Contar em Segundos => 10s = 10 segundos");
            System.Console.WriteLine("Contar em Minutos  =>  1m =  1 minuto");
            System.Console.WriteLine("0s - Sair");
            System.Console.WriteLine("Quanto tempo deseja contar?");

            string choice = Console.ReadLine().ToLower();
            char type = char.Parse(choice.Substring(choice.Length - 1, 1));
            int time = int.Parse(choice.Substring(0, choice.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Ready...");
            Thread.Sleep(800);
            System.Console.WriteLine("Set...");
            Thread.Sleep(600);
            System.Console.WriteLine("Go...");
            Thread.Sleep(400);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine($"Tempo atual: {currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            System.Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}