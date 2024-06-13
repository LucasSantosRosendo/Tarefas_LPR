
using System;
public struct Livros {
        public string titulo;
        public string autor;
        public int anoPublicacao;
        public int numeroPaginas;
        public double preco;
      }
class LucasDosSantos {
  static void Main() {
    
    Livros[] livros = new Livros[3];
    double precototal = 0;
    double media = 0;
    
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Digite os dados dos livros: ");
        Console.Write("Titulo: ");
        livros[i].titulo = Console.ReadLine();
        Console.Write("Autor: ");
        livros[i].autor = Console.ReadLine();
        Console.Write("Ano de Publicação: ");
        livros[i].anoPublicacao = int.Parse(Console.ReadLine());
        Console.Write("Número de páginas: ");
        livros[i].numeroPaginas = int.Parse(Console.ReadLine());
        Console.Write("Preço: ");
        livros[i].preco = double.Parse(Console.ReadLine());
        
        precototal += livros[i].preco; 
        media = livros[i].numeroPaginas/2;
    }
        Console.WriteLine($"O preço total dos livros é de: {precototal}");
        Console.WriteLine($"A média do número de páginas é de: {media}");
  }
}