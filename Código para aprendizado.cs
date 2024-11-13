using System;
using System.Collections.Generic;

// Classe Poder (representa um poder ou habilidade do herói)
public class Poder
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int NivelForca { get; set; } // Nível de força do poder (1-100)

    // Construtor da classe Poder
    public Poder(string nome, string descricao, int nivelForca)
    {
        Nome = nome;
        Descricao = descricao;
        NivelForca = nivelForca;
    }

    // Método para exibir detalhes do poder
    public void ExibirPoder()
    {
        Console.WriteLine($"{Nome}: {Descricao} (Força: {NivelForca}/100)");
    }
}

// Classe Heroi
public class Heroi
{
    public string Nome { get; set; }
    public string IdentidadeSecreta { get; set; }
    public string Origem { get; set; }
    public List<Poder> Poderes { get; private set; }

    // Construtor da classe Heroi
    public Heroi(string nome, string identidadeSecreta, string origem)
    {
        Nome = nome;
        IdentidadeSecreta = identidadeSecreta;
        Origem = origem;
        Poderes = new List<Poder>();
    }

    // Método para adicionar um poder à lista de poderes
    public void AdicionarPoder(Poder poder)
    {
        Poderes.Add(poder);
        Console.WriteLine($"{poder.Nome} foi adicionado aos poderes de {Nome}.");
    }

    // Método para exibir detalhes do herói
    public void ExibirDetalhesHeroi()
    {
        Console.WriteLine($"\nHerói: {Nome}");
        Console.WriteLine($"Identidade Secreta: {IdentidadeSecreta}");
        Console.WriteLine($"Origem: {Origem}");
        Console.WriteLine("\nPoderes e Habilidades:");
        foreach (var poder in Poderes)
        {
            poder.ExibirPoder();
        }
    }
}

class Program
{
    // Método para adicionar um herói personalizado
    static Heroi CriarHeroiPersonalizado()
    {
        Console.WriteLine("Adicione um novo herói!");
        
        // Recebendo os atributos do herói
        Console.Write("Nome do Herói: ");
        string nomeHeroi = Console.ReadLine();

        Console.Write("Identidade Secreta: ");
        string identidadeSecreta = Console.ReadLine();

        Console.Write("Origem do Herói: ");
        string origem = Console.ReadLine();

        // Criando o herói
        Heroi novoHeroi = new Heroi(nomeHeroi, identidadeSecreta, origem);

        // Adicionando poderes
        Console.WriteLine("\nQuantos poderes esse herói terá?");
        int quantidadePoderes = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadePoderes; i++)
        {
            Console.WriteLine($"\nAdicionando poder {i + 1}:");

            Console.Write("Nome do Poder: ");
            string nomePoder = Console.ReadLine();

            Console.Write("Descrição do Poder: ");
            string descricaoPoder = Console.ReadLine();

            Console.Write("Nível de Força (1-100): ");
            int nivelForca = int.Parse(Console.ReadLine());

            // Criando e adicionando o poder ao herói
            Poder poder = new Poder(nomePoder, descricaoPoder, nivelForca);
            novoHeroi.AdicionarPoder(poder);
        }

        return novoHeroi;
    }

    static void Main(string[] args)
    {
        // Criando o herói "Aquila" manualmente para teste
        Heroi heroi1 = new Heroi("Aquila", "Lucas dos Ventos", "Filho dos ventos do oeste");

        // Criando poderes para o herói "Aquila"
        Poder poder1 = new Poder("Controle do Vento", "Manipula o vento para criar tempestades e rajadas", 90);
        Poder poder2 = new Poder("Voo", "Pode voar em alta velocidade usando as correntes de ar", 85);

        // Adicionando poderes ao herói "Aquila"
        heroi1.AdicionarPoder(poder1);
        heroi1.AdicionarPoder(poder2);

        // Exibindo detalhes do herói "Aquila"
        heroi1.ExibirDetalhesHeroi();

        // Criando um herói personalizado a partir da entrada do usuário
        Heroi heroiPersonalizado = CriarHeroiPersonalizado();

        // Exibindo detalhes do herói personalizado
        heroiPersonalizado.ExibirDetalhesHeroi();
    }
}
