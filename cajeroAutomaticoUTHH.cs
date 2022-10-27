// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class sin_titulo {

		static void Main(string[] args) {
			double cuenta;
			double deposito;
			int resp2;
			int respuesta;
			double retiro;
			double saldo;
			saldo = 0;
			resp2 = 1;
			respuesta = 0;
			Console.WriteLine("Bienvenido a l cajero automatico de la UTHH");
			Console.WriteLine("Ingrese numero de cuenta 18 digitos:");
			cuenta = Double.Parse(Console.ReadLine());
			Console.Clear();
			while (resp2==1) {
				Console.WriteLine("1: = Consultar saldo");
				Console.WriteLine("2: = Ingresar saldo");
				Console.WriteLine("3: = Retirar saldo");
				respuesta = int.Parse(Console.ReadLine());
				Console.Clear();
				switch (respuesta) {
				case 1:
					Console.WriteLine("Tu numero de cuenta es: "+cuenta);
					Console.WriteLine("Tu saldo actual es: $"+saldo);
					break;
				case 2:
					Console.WriteLine("Tu numero de cuenta es: "+cuenta);
					Console.WriteLine("Ingresa la cantidad a depositar");
					deposito = Double.Parse(Console.ReadLine());
					saldo = saldo+deposito;
					Console.WriteLine("Tu saldo actual es es: $"+saldo);
					break;
				case 3:
					Console.WriteLine("Ingresa la cantidad a retirar");
					retiro = Double.Parse(Console.ReadLine());
					if (retiro>saldo) {
						Console.WriteLine("La cantidad supera el saldo");
						Console.WriteLine("Tu saldo actual es: $"+saldo);
					} else {
						saldo = saldo-retiro;
						Console.WriteLine("Tu saldo actual es: $"+saldo);
					}
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

