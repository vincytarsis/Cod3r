using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
	class EstruturasSwitch
	{
		public static void Executar() {
			Console.Write("Avalie meu atendimento com uma nota de 1 a 5:");
			int.TryParse(Consele.ReadLine(), out int nota);

			switch (nota) {
				case 0:
					Console.WriteLine("Pessimo");
					break;
				case 1 or case 2:
					Console.WriteLine("Ruim");
				case 3:
					Console.WriteLine("Regular");
					break;
				case 4:
					Console.WriteLine("Bom");
					break;
				case 5:
					Console.WriteLine("Ótimo");
					break;
				default:
					Console.WriteLine("Nota inválida");
					break;
			}
			Console.WriteLine("Obrigado por Responder!");
		}
	}
}