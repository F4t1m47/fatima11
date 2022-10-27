// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			double c;
			double c1;
			double c2;
			double c3;
			double c4;
			int i;
			string l;
			double longitud{text};
			string text;
			Console.WriteLine("ingrese el texto para saber cuantas vocales contiene: ");
			text = Console.ReadLine();
			l = "";
			for (i=-1;i<=text.Length;i++) {
				l = text.Substring(i-1,i-i+1);
				if (l.Equals("a") || l.Equals("A")) {
					c = c+1;
				} else {
					if (l.Equals("e") || l.Equals("E")) {
						c1 = c1+1;
					} else {
						if (l.Equals("i") || l.Equals("I")) {
							c2 = c2+1;
						} else {
							if (l.Equals("o") || l.Equals("O")) {
								c3 = c3+1;
							} else {
								if (l.Equals("u") || l.Equals("U")) {
									c4 = c4+1;
								}
							}
						}
					}
				}
			}
			Console.WriteLine("la cantidad de a= "+c);
			Console.WriteLine("la cantidad de e= "+c1);
			Console.WriteLine("la cantidad de i= "+c2);
			Console.WriteLine("la cantidad de o= "+c3);
			Console.WriteLine("la cantidad de u= "+c4);
		}

	}

}

