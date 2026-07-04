// Crescente ou Decrescente
// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "CRESCENTE", caso os valores tenham sido digitados em ordem crescente, ou "DECRESCENTE", caso os valores tenham sido digitados em ordem decrescente. 
// Caso os valores sejam iguais, o programa deve encerrar a execução.

﻿using System;

namespace crescente
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y;

			Console.WriteLine("Digite dois numeros:");
			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());

			while (x != y)
			{
				if (x > y)
				{
					Console.WriteLine("DECRESCENTE!");
				}
				else
				{
					Console.WriteLine("CRESCENTE!");
				}

				Console.WriteLine("Digite outros dois numeros:");
				x = int.Parse(Console.ReadLine());
				y = int.Parse(Console.ReadLine());
			}
		}
	}
}