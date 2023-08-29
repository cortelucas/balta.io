using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Insira o Primeiro valor: ");
            float firstNumber = float.Parse(Console.ReadLine() ?? "Não inseriu número");

            Console.WriteLine(firstNumber);
        }
    }
}