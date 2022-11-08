using System;

class BusquedaBinaria{
	
	static void Main(){
	
		byte selector;
		bool control = true;
		
		while(control){
			Console.WriteLine("Bienvenido al juego de arrays.");
			Console.WriteLine();
			try{
				Console.WriteLine("1. Ejemplo.");
				Console.WriteLine("2. Juego azar.");
				Console.WriteLine("0. Finalizar.");
				Console.Write("Seleccione la opción: ");
				selector = Convert.ToByte(Console.ReadLine());
				Console.WriteLine();
				switch(selector){
					case 1:
						ejemploArray();
						break;
					case 2:
						juegoArray();
						break;
					case 0:
						Console.WriteLine("Fin.");
						control = false;
						break;
					default:
						Console.WriteLine("Valor introducido incorrecto.");
						Console.WriteLine();
						break;
				}
			}
			catch(Exception errorEncontrado){
				Console.WriteLine("Ha habido un error: " + errorEncontrado.Message);
				Console.WriteLine();
			}
		}	
	}

	static void ejemploArray(){
	
		int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		
		Console.Write("Este es el array: ");
		foreach(int numero in numeros){
			Console.Write(numero + " ");
		}
		Console.WriteLine();
		Console.WriteLine("Quiero encontrar el valor 1 dentro del array.");
		Console.WriteLine("Buscando...");
		
		int valorBuscado = 1, limiteInf = 0, limiteSup = 9;
		bool control = true;
		while(control){
			if (valorBuscado == numeros[limiteSup] || valorBuscado == numeros[limiteInf]){
				Console.WriteLine("Valor encontrado.");
				break;
			}
			int arrayMed = (limiteInf + ((limiteSup - limiteInf)/2));
			if(valorBuscado == numeros[arrayMed]){
			Console.WriteLine("Valor encontrado.");
			control = false;	
			}
			else
				if(limiteInf == (limiteSup-1)){
					Console.WriteLine("Valor no encontrado.");
					control = false;
				}
			if (valorBuscado > numeros[arrayMed])
				limiteInf = arrayMed;
			else
				limiteSup = arrayMed;
		}
		Console.WriteLine();
	}
	
	static void juegoArray(){
		int cantidad = ;					//Me he parado aqui
		int[] numeros = new int [cantidad];
		Random r = new Random();
		for(int i = 0; i < cantidad; i++)
			numeros[i] = r.Next(0, 11);
		foreach(int numero in numeros)
			Console.WriteLine(numero + " ");
	}
}
