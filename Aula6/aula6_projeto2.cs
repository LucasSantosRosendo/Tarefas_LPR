
using System;
class HelloWorld {
  static void Main() {
      
      Random numAleatorio = new Random();
      int valorInteiro = numAleatorio.Next(1,100);
      Console.WriteLine("=== Desafio da Adivinhação ===");
      Console.WriteLine("Para vencer esse jogo você precisa adivinhar o número inteiro gerado entre 1 a 100.");
      do {
          Console.WriteLine("Digite a sua tentativa de um número entre 1 a 100: ");
          int chute = Convert.ToInt32(Console.ReadLine());
          if (chute<1 || chute>100){
              Console.WriteLine("Por favor, digite um valor válido entre 1 a 100 apenas!");
              
          }
      if (chute<valorInteiro){
          Console.WriteLine("Chutou baixo!");
      }
      else if (chute>valorInteiro){
          Console.WriteLine("Chutou alto!");
      }
      else {
          Console.WriteLine("Parabéns! Você acertou o número gerado!");
          break;
      }
      } while (true);
      }
  }