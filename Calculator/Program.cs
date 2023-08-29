using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu ()
        {
            Console.Clear();
            Console.WriteLine("------ Calculator -----");
            Console.WriteLine("--------- MENU --------");
            Console.WriteLine("| Adição ........ (+) |");
            Console.WriteLine("| Subtração ..... (-) |");
            Console.WriteLine("| Multiplicação . (*) |");
            Console.WriteLine("| Divisão ....... (/) |");
            Console.WriteLine("| Sair .......... (0) |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            Console.WriteLine("Insira a Sua Escolha: ");
            string choice = (Console.ReadLine() ?? "0").ToString();

            switch (choice)
            {
                case "+":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    break;
                case "-":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    break;
                case "*":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    break;
                case "/":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    break;
                case "0":
                    Console.WriteLine("Obrigado por usar Calculator");
                    break;
                default:
                    Console.WriteLine("Você não digitou uma opção válida");
                    break;
            }
        }
    }
}