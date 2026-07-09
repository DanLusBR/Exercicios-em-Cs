// Divisão
// Fazer um programa para ler um número inteiro N e depois os dados (número inteiro e divisor) de N casos. Para cada caso, mostrar o resultado da divisão do número inteiro pelo divisor, ou uma mensagem de "divisão impossível", caso seja uma divisão por zero.

using System;
using System.Globalization;

namespace divisao
{
	class Program
	{
		static void Main(string[] args)
		{
			CultureInfo CI = CultureInfo.InvariantCulture;

			int ncasos, numerador, denominador;
			double divisao;

			Console.Write("Quantos casos voce vai digitar? ");
			ncasos = int.Parse(Console.ReadLine());

			for (int i = 0; i < ncasos; i++)
			{
				Console.Write("Entre com o numerador: ");
				numerador = int.Parse(Console.ReadLine());

				Console.Write("Entre com o denominador: ");
				denominador = int.Parse(Console.ReadLine());

				if (denominador == 0)
				{
					Console.WriteLine("DIVISAO IMPOSSIVEL");
				}
				else
				{
					divisao = (double)numerador / denominador;
					Console.WriteLine("DIVISAO = " + divisao.ToString("F2", CI));
				}
			}
		}
	}
}