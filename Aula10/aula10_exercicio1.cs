using System.Collections.Generic;
using System;

class HelloWorld {
    static void Main() {
        List<string> nomes = new List<string>();
        Console.WriteLine("Digite o número de nomes que você deseja digitar: ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++) {
            Console.WriteLine($"Digite o nome {i + 1}:");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }

        List<List<string>> ordem = new List<List<string>>(100);

        for (int i = 0; i < 100; i++) {
            ordem.Add(new List<string>());
        }

        foreach (var nome in nomes) {
            int tamanho = nome.Length;
            if (tamanho < 100) {
                ordem[tamanho].Add(nome);
            }
        }

        for (int i = 0; i < ordem.Count; i++) {
            if (ordem[i].Count > 0) {
                foreach (var nome in ordem[i]) {
                    Console.WriteLine(nome);
                }
            }
        }
    }
}