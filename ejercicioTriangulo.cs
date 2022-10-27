// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			double l1;
			double l2;
			double l3;
			double p;
			Console.WriteLine("ingrese lado 1");
			l1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese lado 2");
			l2 = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese lado 3");
			l3 = Double.Parse(Console.ReadLine());
			p = l1+l2+l3;
			Console.WriteLine("El perimetro del triangulo es:"+p);
			if (l1==l2 && l1==l3) {
				Console.WriteLine("Tirangulo equilatero");
			} else {
				if (l1!=l2 && l1!=l3 && l2!=l3) {
					Console.WriteLine("Triangulo escaleno");
				} else {
					if (l1==l2 || l1==l3 || l2==l3) {
						Console.WriteLine("Triangulo Isosceles");
					}
				}
			}
		}

	}

}

