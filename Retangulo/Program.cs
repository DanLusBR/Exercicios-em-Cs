// Retangulo
// Faça um programa em C# que leia a base e a altura de um retângulo. Em seguida, o programa deve calcular a área (base × altura), o perímetro (2 × (base + altura)) e a diagonal (raiz quadrada de base² + altura²). Ao final, exiba
//os valores da área, do perímetro e da diagonal com quatro casas decimais, utilizando a cultura invariável (ponto como separador decimal).

﻿using System;
using System.Globalization;

namespace retangulo
{
	class Program
	{
		static void Main(string[] args)
		{
			CultureInfo CI = CultureInfo.InvariantCulture;

			double basee, altura, area, perimetro, diagonal;

			Console.Write("Base do retangulo: ");
			basee = double.Parse(Console.ReadLine(), CI);

			Console.Write("Altura do retangulo: ");
			altura = double.Parse(Console.ReadLine(), CI);

			area = basee * altura;

			Console.WriteLine("AREA = " + area.ToString("F4", CI));

			perimetro = 2 * (basee + altura);

			Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));

			diagonal = Math.Sqrt(basee * basee + altura * altura);

			Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
		}
	}
}