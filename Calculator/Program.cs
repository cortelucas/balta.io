﻿using System;

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
                    string[] inputData = Console.ReadLine().Split(",");
                    float[] numbers = MakeArray(inputData);
                    
                    Console.WriteLine($"A soma dos números é: {Add(numbers)}");

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

        static float[] MakeArray(string[] inputData)
        {
            return Array.ConvertAll(inputData, float.Parse);
        }
    }
}