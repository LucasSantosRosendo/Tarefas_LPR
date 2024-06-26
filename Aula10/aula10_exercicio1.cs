using System.Collections.Generic;
using System;
class HelloWorld {
  static void Main() {
       List<string> nomes = new List<string>();
       Console.WriteLine("Digite o valor de nomes que você deseja digitar: ");
       int quantidade = int.Parse(Console.ReadLine());
       
       for (int i = 0; i < quantidade; i++)
       {
           string nome = Console.ReadLine();
           nomes.Add(nome);
          
       }
       
       List<string> ordem[] = new List<string>[100];
       
       for (int i = 0; < ordem.Length; i++)
       {
           ordem[i] = new List<string>();
       }
       
       
      foreach (var nome in nomes)
      {
          int tamanho = nome.Length;
          ordem[length].Add(nome); 
      }
      
      for (int i = 0; i < ordem.Length; i++)
      {
          Console.WriteLine()
      }
      
}
}