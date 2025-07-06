/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira data (formato: dd/MM/yyyy):");
            DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy):");
            DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            TimeSpan diferenca = data2 - data1;

            Console.WriteLine($"A diferença entre as datas é de {Math.Abs(diferenca.Days)} dia(s).");
            Console.ReadKey(true);
        }
    }
}
