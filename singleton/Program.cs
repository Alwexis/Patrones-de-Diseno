using System;
using Patrones_de_Diseno.clases;

namespace Patrones_de_Diseno {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello World!");
			Singleton v = Singleton.getInstance();
			v.nombre = "Gonzalo";
			// Conservará el valor asignado arriba independientemente de la variable.
			Singleton s2 = Singleton.getInstance();
			Console.WriteLine(s2.nombre);

			Console.WriteLine(v.nombre);

			Console.WriteLine("****************************** " + v.nombre);

		}
	}
}
