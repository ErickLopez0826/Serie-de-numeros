using System;
class SerieNumeros{
    static void Main(){
        //variable para contador de cuantas vececes ingresaron numeros diferentes a 0
        int contador = 0;
        while (true){
            Console.Write("Ingrese un numero. Si ingresa 0 finalizara el programa: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero)){
                Console.Write("Ingrese un numero entero");
            }
            if (numero == 0)
            {
                break;
            }
            Console.WriteLine($"Numero ingresado: {numero}");
            // Contador que incrementa en 1 cada que ingresan un numero desigual a 0
            contador++;
        }
        Console.WriteLine($"\nSe leyeron un total de {contador} numeros distintos de cero.");
    }
}
