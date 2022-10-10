using System;

namespace CursoCSharp.Fundamentos
{
	class OperadoresAtribuicao
	{
		public static void Executar()
		{
			var num1 = 3;
			num1 = 7;
			num1 += 10; // num1 = num1 + 10
			num1 -= 3; // num1 = num1 - 3
			num1 *= 5; // num1 = num1 * 5
			num1 /= 2; // num1 = num1 / 2

			Console.WriteLine($"{a} {b}");

			// Não se preocupe com o código
			dynamic c = new System.Dynamic.ExpandoObject();
			c.nome = "João";

			dynamic d = c;
			d.nome = "Maria";

			Console.WriteLine(c.nome);
		}
	}
}
