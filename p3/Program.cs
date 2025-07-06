/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 28/06/2025
 * Time: 17:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento (formato: Dia(00)/Mes(00)/Ano(0000):");
            DateTime nascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            DateTime hoje = DateTime.Today;

            int idade = hoje.Year - nascimento.Year;

            if (nascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            Console.WriteLine($"Você tem {idade} ano(s) de idade.");
            Console.ReadKey(true);
        }
    }
}
