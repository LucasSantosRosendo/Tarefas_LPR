using System;
using System.Collections.Generic;
using System.Linq;

public class Aluno
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; private set; }
    public Aluno(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    
    public void AdicionarMatricula(Turma turma)
    {
        
        if (Matriculas.Any(m => m.Turma == turma))
        {
            Console.WriteLine($"{Nome} já está matriculado na turma {turma.Nome}.");
            return;
        }

       
        Matricula matricula = new Matricula(DateTime.Now, this, turma);
        Matriculas.Add(matricula);
        turma.Matriculas.Add(matricula);

        Console.WriteLine($"{Nome} foi matriculado na turma {turma.Nome}.");
    }
}
public class Turma
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; private set; }
    public Turma(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }
    public void ListarAlunos()
    {
        Console.WriteLine($"\nAlunos matriculados na turma {Nome}:");
        foreach (var matricula in Matriculas)
        {
            Console.WriteLine($"{matricula.Aluno.Nome} (matriculado em: {matricula.DataMatricula.ToShortDateString()})");
        }
    }
}
public class Matricula
{
    public DateTime DataMatricula { get; set; }
    public Aluno Aluno { get; set; }
    public Turma Turma { get; set; }

    public Matricula(DateTime dataMatricula, Aluno aluno, Turma turma)
    {
        DataMatricula = dataMatricula;
        Aluno = aluno;
        Turma = turma;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("João Silva");
        Aluno aluno2 = new Aluno("Maria Souza");
        Aluno aluno3 = new Aluno("Pedro Oliveira");
        Turma turma1 = new Turma("Matemática");
        Turma turma2 = new Turma("História");
        aluno1.AdicionarMatricula(turma1);
        aluno2.AdicionarMatricula(turma1);
        aluno1.AdicionarMatricula(turma2);
        aluno3.AdicionarMatricula(turma2);
        aluno1.AdicionarMatricula(turma1);
        turma1.ListarAlunos();
        turma2.ListarAlunos();
    }
}
