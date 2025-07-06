/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data (formato: dd/MM/yyyy):");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            
            DateTime[] feriados = new DateTime[]
            {
            new DateTime(data.Year, 1, 1),   // Confraternização Universal
            new DateTime(data.Year, 4, 21),  // Tiradentes
            new DateTime(data.Year, 5, 1),   // Dia do Trabalho
            new DateTime(data.Year, 9, 7),   // Independência do Brasil
            new DateTime(data.Year, 10, 12), // Nossa Senhora Aparecida
            new DateTime(data.Year, 11, 2),  // Finados
            new DateTime(data.Year, 11, 15), // Proclamação da República
            new DateTime(data.Year, 12, 25)  // Natal
            };

            if (Array.Exists(feriados, f => f.Date == data.Date))
                Console.WriteLine("É um feriado nacional.");
            else
                Console.WriteLine("Não é um feriado nacional.");
            Console.ReadKey(true);
        }
    }
}

