using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia as 3 notas de um aluno e calcule a média final deste aluno. 
             * Considere que a média é ponderada e que o peso das notas é: 2,3 e 5, respectivamente.*/

            Console.WriteLine("===== Algoritmo para ler 3 notas do aluno e mostrar a média final =====");

            Console.WriteLine();
            Console.Write("Digite sua primeira nota: ");

            double note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Digite sua segunda nota: ");

            double note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Digite sua terceira nota: ");
            double note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            if (note1 < 0 || note2 < 0 || note3 < 0)
            {
                Console.WriteLine("A nota não pode ser menor que 0!");
                return;
            }

            double average = (note1 * 2) + (note2 * 3) + (note3 * 5) / 10;

            Console.WriteLine();

            Console.WriteLine($"A média ponderada deste aluno é: {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}