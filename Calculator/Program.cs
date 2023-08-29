using System;

namespace Calculator
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
            string[] menuLines = {
                "┏━━━━━  Calculator  ━━━━━┓",
                "┣━━━━━     MENU     ━━━━━┫",
                "┃ Adição ........... [+] ┃",
                "┃ Subtração ........ [-] ┃",
                "┃ Multiplicação .... [*] ┃",
                "┃ Divisão .......... [/] ┃",
                "┃ Sair ............. [0] ┃",
                "┗━━━━━━━━━━━━━━━━━━━━━━━━┛"
            };
            foreach (string line in menuLines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            Console.WriteLine("Insira a Sua Escolha, por exemplo *: ");
            string choice = (Console.ReadLine() ?? "0").ToString();

            ChooseAction(choice);
        }

        static float[] MakeArray(string[] inputData)
        {
            return Array.ConvertAll(inputData, float.Parse);
        }

        static void ChooseAction(string choice)
        {
            switch (choice)
            {
                case "+":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    string[] inputDataAdd = Console.ReadLine().Split(",");
                    float[] numbersAdd = MakeArray(inputDataAdd);

                    Console.WriteLine($"A soma dos números é: {Add(numbersAdd)}");

                    break;
                case "-":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    string[] inputDataSubtract = Console.ReadLine().Split(",");
                    float[] numbersSubtract = MakeArray(inputDataSubtract);

                    Console.WriteLine($"A subtração dos números é: {Subtract(numbersSubtract)}");
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

        static float Add(float[] numbers)
        {
            float count = 0;
            foreach (var number in numbers)
            {
                float value = count + number;
                count = value;
            }

            return count;
        }

        static float Subtract(float[] numbers)
        {
            float count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    count = numbers[i];
                }
                else
                {
                    count -= numbers[i];
                }
            }

            return count;
        }
    }
}