// Combustivel
// Neste problema, você deve ler os códigos de um combustível abastecido e contar quantas vezes cada combustível foi abastecido, sabendo que os códigos são: 1 para álcool, 2 para gasolina e 3 para diesel. O código 4 encerra o programa. Apresente a mensagem "MUITO OBRIGADO" e a quantidade de cada combustível abastecido, conforme exemplo.


using System;

namespace combustivel
{
	class Program
	{
		static void Main(string[] args)
		{
			int codigo, alcool, gasolina, diesel;

			Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
			codigo = int.Parse(Console.ReadLine());

			alcool = 0;
			gasolina = 0;
			diesel = 0;

			while (codigo != 4)
			{
				if (codigo == 1)
				{
					alcool++;
				}
				else if (codigo == 2)
				{
					gasolina++;
				}
				else if (codigo == 3)
				{
					diesel++;
				}
				Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
				codigo = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("MUITO OBRIGADO");
			Console.WriteLine("Alcool: " + alcool);
			Console.WriteLine("Gasolina: " + gasolina);
			Console.WriteLine("Diesel: " + diesel);
		}
	}
}