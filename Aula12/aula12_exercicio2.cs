using System;
using System.Collections.Generic;
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}
public class Biblioteca
{
    public List<Livro> Livros { get; private set; }
    public Biblioteca()
    {
        Livros = new List<Livro>();
    }
    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
    }
    public void ListarLivros()
    {
        Console.WriteLine("\nLista de livros na biblioteca:");
        foreach (var livro in Livros)
        {
            Console.WriteLine($"{livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}");
        }
    }
    public void AdicionarLivroUsuario()
    {
        Console.WriteLine("\nDigite as informações do livro que deseja adicionar:");

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Ano de Publicação: ");
        int anoPublicacao;
        while (!int.TryParse(Console.ReadLine(), out anoPublicacao))
        {
            Console.Write("Por favor, insira um ano válido: ");
        }
        Livro novoLivro = new Livro(titulo, autor, anoPublicacao);
        AdicionarLivro(novoLivro);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        Livro livro1 = new Livro("1984", "George Orwell", 1949);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro3 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954);

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);
        biblioteca.ListarLivros();
        biblioteca.AdicionarLivroPeloConsole();
        biblioteca.ListarLivros();
    }
}
