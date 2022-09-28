using System;
using Patrones_de_Diseno.clases;

namespace Patrones_de_Diseno {
	class Program {
		static void Main(string[] args) {
			Sistema1 sistema1 = new Sistema1();
			Sistema2 sistema2 = new Sistema2();

			Facade facade = new Facade(sistema1, sistema2);
			Cliente.ClientCode(facade);
		}
	}
}
