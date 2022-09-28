using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_de_Diseno.clases {
	public class Facade {
		Sistema1 s1;
		Sistema2 s2;

		public Facade(Sistema1 s1, Sistema2 s2) {
			this.s1 = s1;
			this.s2 = s2;
		}

		public string operacion() {
			string result = "inicio fachada";
			result += this.s1.operacion1();
			result += this.s2.operacion1();
			result += this.s1.operacion2();
			result += this.s2.operacion2();

			return result;
		}
	}
}
