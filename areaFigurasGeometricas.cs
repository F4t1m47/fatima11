// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			double altura;
			double area;
			double base;
			double base2;
			double diagonalmay;
			double diagonalmeno;
			double duagonalmeno;
			double lado;
			double perimetro;
			double radio;
			int resp2;
			int respuesta;
			resp2 = 1;
			respuesta = 0;
			while (resp2==1) {
				Console.WriteLine("SELECCIONA LA FIGURA QUE DESEA CONOCER EL ÁREA");
				Console.WriteLine("1: = CUADRADO");
				Console.WriteLine("2: = RECTANGULO");
				Console.WriteLine("3: = TRIANGULO");
				Console.WriteLine("4: = ROMBO");
				Console.WriteLine("5: = ROMBOIDE");
				Console.WriteLine("6: = TRAPECIO");
				Console.WriteLine("7: = CIRCULO");
				respuesta = int.Parse(Console.ReadLine());
				Console.Clear();
				switch (respuesta) {
				case 1:
					Console.WriteLine("INGRESA EL LADO ");
					lado = Double.Parse(Console.ReadLine());
					area = lado*lado;
					perimetro = lado+lado+lado+lado;
					Console.WriteLine("El área del cuadreado es de: "+area);
					Console.WriteLine("El perimetro del cuadreado es de: "+perimetro);
					break;
				case 2:
					Console.WriteLine("INGRESA LA BASE:");
					base = Double.Parse(Console.ReadLine());
					Console.WriteLine("INGRESA LA ALTURA:");
					altura = Double.Parse(Console.ReadLine());
					area = base*altura;
					perimetro = base+base+altura+altura;
					Console.WriteLine("El área del cuadreado es de: "+area);
					Console.WriteLine("El perimetro del cuadreado es de: "+perimetro);
					break;
				case 3:
					Console.WriteLine("INGRESA LA BASE:");
					base = Double.Parse(Console.ReadLine());
					Console.WriteLine("INGRESA LA ALTURA:");
					altura = Double.Parse(Console.ReadLine());
					area = (base*altura)/2;
					Console.WriteLine("El área del cuadreado es de: "+area);
					break;
				case 4:
					Console.WriteLine("INGRESA LA DIAGONAL MAYOR");
					diagonalmay = Double.Parse(Console.ReadLine());
					Console.WriteLine("INGRESA LA DIAGONAL MENOR");
					diagonalmeno = Double.Parse(Console.ReadLine());
					area = diagonalmay*diagonalmeno;
					Console.WriteLine("El área del cuadreado es de: "+area);
					break;
				case 5:
					Console.WriteLine("INGRESA LA BASE:");
					base = Double.Parse(Console.ReadLine());
					Console.WriteLine("INGRESA LA ALTURA:");
					altura = Double.Parse(Console.ReadLine());
					area = base*altura;
					perimetro = base+base+altura+altura;
					Console.WriteLine("El área del cuadreado es de: "+area);
					Console.WriteLine("El perimetro del cuadreado es de: "+perimetro);
					break;
				case 6:
					Console.WriteLine("INGRESA LA BASE MENOR:");
					base = Double.Parse(Console.ReadLine());
					Console.WriteLine("INGRESA LA BASE MAYOR:");
					base2 = Double.Parse(Console.ReadLine());
					Console.WriteLine("INGRESA LA ALTURA:");
					altura = Double.Parse(Console.ReadLine());
					area = base*altura;
					Console.WriteLine("El área del cuadreado es de: "+area);
					break;
				case 7:
					Console.WriteLine("INGRESA EL RADIO:");
					radio = Double.Parse(Console.ReadLine());
					area = 3.14*(radio*2);
					Console.WriteLine("El área del circulo es de: "+area);
					break;
				}
				Console.WriteLine("¿Deseas realizar otra operación?");
				Console.WriteLine("precione [1] para Si o precione [2] para No");
				resp2 = int.Parse(Console.ReadLine());
				Console.Clear();
			}
		}

	}

}

