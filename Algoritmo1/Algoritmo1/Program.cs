using System;

namespace MyApp 

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e
            mostre-a expressa apenas em dias. Explique/descreva o raciocínio que você teve para
            resolver o problema.*/

            Console.WriteLine("====== Algoritmo para ler anos, meses e dias e retornar apenas os dias =====");
            Console.WriteLine();
            Console.WriteLine("Digite os anos, meses e dias da seguinte forma (YY/MM/DD) ex: 21/05/15: ");

            string yearsAndMonthsAndDays = Console.ReadLine();

            if(!yearsAndMonthsAndDays.Contains("/"))
            {
                Console.WriteLine("Os anos, meses e dias devem ser separados por / desta forma ex: 21/05/15");
                return;
            }

            string[] yearsAndMonthsAndDaysFormat = yearsAndMonthsAndDays.Split("/");

            int years = int.Parse(yearsAndMonthsAndDaysFormat[0]);

            int months = int.Parse(yearsAndMonthsAndDaysFormat[1]);

            // ["23", "06", "23"]


            if(months > 12)
            {
                Console.WriteLine("O mês não pode ser maior que 12, ex se for 13 meses colocar 01/01/00");
                return;
            }

            int days = int.Parse(yearsAndMonthsAndDaysFormat[2]);

            if(days > 30)
            {
                Console.WriteLine("Os dias não podem ser maior que 30, ex 32 dias colocar 00/01/02");
                return;
            }

            int convertInDays = (years * 365) + (months * 30) + days;

            Console.WriteLine();
            Console.WriteLine($"A data que você digitou {years}/{months}/{days} são equivalentes a {convertInDays} dias.");

        }
    }
}