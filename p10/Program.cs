/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 18:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p10
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um número de 1 a 7:");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Domingo"); break;
                case 2: Console.WriteLine("Segunda-feira"); break;
                case 3: Console.WriteLine("Terça-feira"); break;
                case 4: Console.WriteLine("Quarta-feira"); break;
                case 5: Console.WriteLine("Quinta-feira"); break;
                case 6: Console.WriteLine("Sexta-feira"); break;
                case 7: Console.WriteLine("Sábado"); break;
                default: Console.WriteLine("Número inválido."); break;
            }
        }
    }
}

