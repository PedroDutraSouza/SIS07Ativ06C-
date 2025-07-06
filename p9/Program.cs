/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 18:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p9
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite uma letra:");
            char letra = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (!char.IsLetter(letra))
            {
                Console.WriteLine("Isso não é uma letra.");
            }
            else if ("aeiou".Contains(letra))
            {
                Console.WriteLine("É uma vogal.");
            }
            else
            {
                Console.WriteLine("É uma consoante.");
            }
        }
    }
}
