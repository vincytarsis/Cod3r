using System;
using System.Collections.Gemeric;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
	class DesafioAtributo
	{
		int a = 10;

		public static void Executar()
		{
			// Acessar variál 'a' dentro do método Executar!
			//Console.WriteLine(a)

			DesafioAtributo desafio = new DesafioAtributo();
			Console.WriteLine(desafio.a);
		}
	
	}
}
