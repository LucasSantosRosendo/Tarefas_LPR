
using System;
class HelloWorld {
  static void Main() {
    int somaNumeros = 0;
    for (int numero = 50; numero <= 500; numero++){
        if (numero % 2 != 0 && numero % 3 == 0)
            {
                somaNumeros += numero;
            }
        }
        Console.WriteLine("A soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500 é: ");
        Console.WriteLine($"Soma: {somaNumeros}");
    }
  }