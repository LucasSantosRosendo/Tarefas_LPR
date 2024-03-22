
using System;
class HelloWorld {
  static void Main() {
      int soma = 0;
      float media;
      Console.WriteLine("Digite a quantidade de números fornecidos: ");
    int quantidade = int.Parse(Console.ReadLine());
    int quantidade2 = quantidade;
      while(quantidade>0){
          int contagem = int.Parse(Console.ReadLine());
          if (contagem%2 == 0){
              soma += contagem;
          }
          quantidade--;
      }
       media = soma/quantidade2;
          Console.WriteLine($"O resultado dessa operação é igual a: {media}");
  }
}