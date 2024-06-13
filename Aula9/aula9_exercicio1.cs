
using System;
public struct Produto {
        public string nome;
        public int codigo;
        public double preco;
        public int quantidade;
      }
class LucasDosSantos {
  static void Main() {
    
    Produto[] produtos = new Produto[3];
    int estoque = 0;
    
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Digite os dados do produto: ");
        Console.Write("Nome: ");
        produtos[i].nome = Console.ReadLine();
        Console.Write("Código: ");
        produtos[i].codigo = int.Parse(Console.ReadLine());
        Console.Write("Preço: ");
        produtos[i].preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        produtos[i].quantidade = int.Parse(Console.ReadLine());
        estoque += produtos[i].quantidade;
    
    }
    Console.WriteLine("O valor total em estoque dos produtos digitados é de: {0}", estoque);
  }
}