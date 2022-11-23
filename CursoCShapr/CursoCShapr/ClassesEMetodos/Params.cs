using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
	class Params {

		public static void Recepcionar(params string[] pessoas) {

			foreach (var pessoa in pessoas)
			{
				Console.WriteLine($"Olá {pessoa}");
			}
		}
		public static void Executar() {

			Recepcionar("Vincy", "Pedro", "Bia", "Duda");
		}
	}
}
