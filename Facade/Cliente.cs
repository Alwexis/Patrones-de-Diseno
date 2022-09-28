using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_de_Diseno.clases {
	public class Cliente {
		public static void ClientCode(Facade facade) {
			Console.WriteLine(facade.operacion());
		}
	}
}
