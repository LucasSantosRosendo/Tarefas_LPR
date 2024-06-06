
using System;
class HelloWorld {
  static void Main() {
      
      int[] numeros = new int[10];
      int[] pares = new int[10];
      int[] impares = new int[10];
      
      Console.WriteLine("Insira 10 números da sua escolha: ");
      
      for (int i = 0; i< numeros.Length; i++)
      {
          numeros[i] = int.Parse(Console.ReadLine());
      }
      for (int i = 0; i<10; i++)
      {
          if (numeros[i]%2 == 0)
          {
              pares[i] = numeros[i];
          }
          else
          {
              impares[i] = numeros[i];
          }
      }
      
      Console.WriteLine("Os números pares são: ");
      for (int i = 0; i<10; i++)
      {
          Console.WriteLine(pares[i]);
      }
      
      Console.WriteLine("Os números ímpares são: ");
      for (int i = 0; i<10; i++)
      {
          Console.WriteLine(impares[i]);
      }
  }
}