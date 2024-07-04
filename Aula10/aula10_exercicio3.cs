using System.Collections.Generic;

using System;
class HelloWorld {
  static void Main() {
      
    Dictionary<string, int> informacoesPessoas = new Dictionary<string, int>();
    informacoesPessoas.Add("Ana", 17);
    informacoesPessoas.Add("Fernanda", 18);
    informacoesPessoas.Add("Paola", 19);
    informacoesPessoas.Add("Giovana", 20);
    
    int idadeAna = informacoesPessoas["Ana"];
    int idadeFernanda = informacoesPessoas["Fernanda"];
    int idadePaola = informacoesPessoas["Paola"];
    int idadeGiovana = informacoesPessoas["Giovana"];
    int media;
    
    media = (idadeAna + idadeFernanda + idadePaola + idadeGiovana)/4;
    
    Console.WriteLine("As pessoas com idade acima da média são: ");
    
    foreach (var aluno in informacoesPessoas) if (aluno.Value > media) {
    Console.WriteLine(aluno.Key);
    }
    
    if ((idadeAna > idadeFernanda) && (idadeAna > idadePaola) && (idadeAna > idadeGiovana) && (idadeAna > idadeGiovana))
    {
        Console.WriteLine("A pessoa mais velha é: Ana");
    }
    
    else if ((idadeFernanda > idadeAna) && (idadeFernanda > idadePaola) && (idadeFernanda > idadeGiovana))
    {
        Console.WriteLine("A pessoa mais velha é: Fernanda");
    }
    
    else if ((idadePaola > idadeAna) && (idadePaola > idadeFernanda) && (idadePaola > idadeGiovana))
    {
        Console.WriteLine("A pessoa mais velha é: Paola");
    }
    
    else 
    {
        Console.WriteLine("A pessoa mais velha é: Giovana");
    }
    
    if ((idadeAna < idadeFernanda) && (idadeAna < idadePaola) && (idadeAna < idadeGiovana) && (idadeAna < idadeGiovana))
    {
        Console.WriteLine("A pessoa mais nova é: Ana");
    }
    
    else if ((idadeFernanda < idadeAna) && (idadeFernanda < idadePaola) && (idadeFernanda < idadeGiovana))
    {
        Console.WriteLine("A pessoa mais nova é: Fernanda");
    }
    
    else if ((idadePaola < idadeAna) && (idadePaola < idadeFernanda) && (idadePaola < idadeGiovana))
    {
        Console.WriteLine("A pessoa mais nova é: Paola");
    }
    
    else 
    {
        Console.WriteLine("A pessoa mais nova é: Giovana");
    }
    
    Console.WriteLine("Digite um valor inteiro correspondente a uma idade para remover do dicionário de idades: ");
    int valor = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Pessoa(s) removida(s) do dicionário: ");
    foreach (var aluno in informacoesPessoas) if (aluno.Value == valor) {
    Console.WriteLine(aluno.Key);
    }
  }
}