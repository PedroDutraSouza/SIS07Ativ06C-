/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 19:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p11
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Escolha o tamanho da camiseta (P, M ou G):");
            string tamanho = Console.ReadLine().ToUpper();

            switch (tamanho)
            {
                case "P":
                    Console.WriteLine("Preço: R$ 29,90");
                    break;
                case "M":
                    Console.WriteLine("Preço: R$ 34,90");
                    break;
                case "G":
                    Console.WriteLine("Preço: R$ 39,90");
                    break;
                default:
                    Console.WriteLine("Tamanho inválido.");
                    break;
            }
        }
    }
}
