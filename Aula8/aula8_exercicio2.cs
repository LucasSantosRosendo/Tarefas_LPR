
using System;
class HelloWorld {
  static void Main() {
      
      int[] numeros = new int[10];
      int contador = 0;
      
      Console.WriteLine("Insira 10 números da sua escolha: ");
      
      for (int i = 0; i< numeros.Length; i++)
      {
          numeros[i] = int.Parse(Console.ReadLine());
      }
      
      Console.WriteLine("Qual número você gostaria de pesquisar no vetor?");
      int escolha = int.Parse(Console.ReadLine());
      for (int i = 0; i<10; i++)
      {
      if (numeros[i] == escolha)
      {
          Console.WriteLine("O número que você digitou está na posição:");
          Console.WriteLine(i);
          contador++;
      }
          
      if (contador!=0)
      {
          Console.WriteLine($"O número que você digitou foi repetido: {contador}");
      }
  }
}
}