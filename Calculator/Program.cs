using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
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
                    Add(Console.ReadLine().Split(","));

                    break;
                case "-":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    Subtract(Console.ReadLine().Split(","));

                    break;
                case "*":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    Multiply(Console.ReadLine().Split(","));
                    break;
                case "/":
                    Console.WriteLine("Insira os números, separados por ',': ");
                    Divide(Console.ReadLine().Split(","));
                    break;
                case "0":
                    Console.WriteLine("Obrigado por usar Calculator");
                    break;
                default:
                    Console.WriteLine("Você não digitou uma opção válida");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("");
            
            Menu();
        }

        static void Add(string[] inputData)
        {
            float[] numbers = MakeArray(inputData);
            float result = 0;
            foreach (var number in numbers)
            {
                float value = result + number;
                result = value;
            }

            Console.WriteLine($"A soma dos números é: { result }");
        }

        static void Subtract(string[] inputData)
        {
            float[] numbers = MakeArray(inputData);
            float result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    result -= numbers[i];
                }
            }

            Console.WriteLine($"A subtração dos números é: { result }");
        }

        static void Multiply(string[] inputData)
        {
            float[] numbers = MakeArray(inputData);
            float result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    result *= numbers[i];
                }
            }

            Console.WriteLine($"A multiplicação dos números é: { result }");
        }

        static void Divide(string[] inputData)
        {
            float[] numbers = MakeArray(inputData);
            float result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("ERRO: Não pode ser feito divisão por 0.");
                }
                else
                {
                    if (i == 0)
                    {
                        result = numbers[i];
                    }
                    else
                    {
                        result /= numbers[i];
                    }
                }
            }

            Console.WriteLine($"A divisão dos números é: { result }");
        }
    }
}