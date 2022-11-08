using System;

class SumaRestaR{
	
	static void Main(){
		
		Random r = new Random();
		int i, n=2, selector=0, solucion=0, intento=0;	//selector sirve para escoger el operador
		string operadores="+-";							//array de operadores + y - de donde escogerlos
		int[] numeros = new int[n]; 					//array de 3 números random
		bool control;
	
		for(int contador = 1; contador < 11; contador++){
			control = true;
			for(i=0; i < n; i++){ 							//relleno el array/string
				numeros[i] = r.Next(1,10);
			}
			selector = r.Next(0,2);
			
			if(operadores[selector] == '+'){
				solucion = numeros[0] + numeros[1];
				while (control){
					try{
						Console.Write(numeros[0] + " + " + numeros[1] + " = ");
						intento = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine();
						if(solucion == intento)
							control=false;
					}
					catch(Exception errorEncontrado){
						Console.WriteLine("Ha habido un error: " + errorEncontrado.Message);
						Console.WriteLine();
					}
				}
			}
			else{
				solucion = numeros[0] - numeros[1];
				while (control){
					try{
						Console.Write(numeros[0] + " - " + numeros[1] + " = ");
						intento = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine();
						if(solucion == intento)
							control=false;
					}
					catch(Exception errorEncontrado){
						Console.WriteLine("Ha habido un error: " + errorEncontrado.Message);
						Console.WriteLine();
					}
				}
			}
		}
	}
}
