// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			double c1;
			double c2;
			double c3;
			string n1;
			string n2;
			string n3;
			c1 = 0;
			c2 = 0;
			c3 = 0;
			Console.WriteLine("Ingrese el nombre completo del primer alumno:");
			n1 = Console.ReadLine();
			Console.WriteLine("Ingrese la calificación del alumno: ");
			c1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre completo del segundo alumno:");
			n2 = Console.ReadLine();
			Console.WriteLine("Ingrese la calificación del alumno: ");
			c2 = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre completo del tercer alumno:");
			n3 = Console.ReadLine();
			Console.WriteLine("Ingrese la calificación del alumno: ");
			c3 = Double.Parse(Console.ReadLine());
			if (c1>c2 && c1>c2) {
				Console.WriteLine("El alumno que obtubo el primero lugar es: "+n1+" con: "+c1+" de calificación");
			} else {
				if (c2>c1 && c2>c3) {
					Console.WriteLine("El alumno que obtubo el primero lugar es: "+n2+" con: "+c2+" de calificación");
				} else {
					if (c3>c2 && c3>c1) {
						Console.WriteLine("El alumno que obtubo el primero lugar es: "+n3+" con: "+c3+" de calificación");
					} else {
						if (c1==c2 || c1==c3 || c2==c3) {
							Console.WriteLine("Los tres tienen el mismo promedio, por lo tanto es un empate");
						}
					}
				}
			}
		}

	}

}

