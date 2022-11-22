using System;
using System.Collections.Gemeric;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
	class Params
	{
		public static void Recepcionar(params string[] pessoas)
		{
			foreach (var pessoa in pessoas)
			{
				Console.WriteLine($"Olá {pessoa}");
			}
		}
		public static void Executar()
		{
			Recepcionar("Vincy", "Pedro", "Bia", "Duda");
		}
	}
}
