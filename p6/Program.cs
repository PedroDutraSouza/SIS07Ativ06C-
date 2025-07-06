/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 18:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("O número é positivo.");
            else if (numero < 0)
                Console.WriteLine("O número é negativo.");
            else
                Console.WriteLine("O número é zero.");
        }
    }
}
