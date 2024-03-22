
using System;
class HelloWorld {
  static void Main() {
      int numero, digito, resultado;
      int soma = 0;
    Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
    resultado = numero*numero;
    
    while (resultado>0){
        digito = resultado%10;
        soma += digito;
        resultado /= 10;
        
    }
    Console.WriteLine($"A soma dos digitos do número solicitado ao quadrado é igual a: {soma}");
  }
}