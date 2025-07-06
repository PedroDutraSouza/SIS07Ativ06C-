/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 18:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Iniciar");
            Console.WriteLine("2 - Configurações");
            Console.WriteLine("3 - Sair");

            string opcao = Console.ReadLine();

            if (opcao == "1")
                Console.WriteLine("Você escolheu Iniciar.");
            else if (opcao == "2")
                Console.WriteLine("Você escolheu Configurações.");
            else if (opcao == "3")
                Console.WriteLine("Você escolheu Sair.");
            else
                Console.WriteLine("Opção inválida.");
        }
    }
}

