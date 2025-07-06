/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 18:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma cor (vermelho, azul ou verde):");
            string cor = Console.ReadLine().ToLower();

            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("Você escolheu vermelho.");
                    break;
                case "azul":
                    Console.WriteLine("Você escolheu azul.");
                    break;
                case "verde":
                    Console.WriteLine("Você escolheu verde.");
                    break;
                default:
                    Console.WriteLine("Cor inválida.");
                break;
            }  
        }   
    }
}

