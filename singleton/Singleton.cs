using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_de_Diseno.clases {
	public class Singleton {

		private static Singleton _instance;

		private Singleton() {
		}

		// Lo que hace es devolver una instancia de Singleton en caso de que exista, y sino, la crea y la devuelve.
		public static Singleton getInstance() {
			if (_instance == null) {
				_instance = new Singleton();
			}
			return _instance;
		}

		public string nombre;
	}
}
