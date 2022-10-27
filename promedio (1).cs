// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			int acum;
			double n;
			int notas;
			double prom;
			double promo;
			double suma;
			acum = 1;
			suma = 0;
			Console.WriteLine("¿Cuantas notas desea promediar?");
			notas = int.Parse(Console.ReadLine());
			while (acum<=notas) {
				Console.WriteLine("ingrese la nota numero "+acum);
				n = Double.Parse(Console.ReadLine());
				suma = suma+n;
				acum = acum+1;
			}
			prom = suma/notas;
			Console.WriteLine("El promedio es: "+prom);
			if (promo>=3) {
				Console.WriteLine("El estudiante gano la materia");
			} else {
				Console.WriteLine("El estudiante perdió la materia");
			}
		}

	}

}

