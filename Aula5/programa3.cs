using System;
class HelloWorld {
static void Main() {
Console.WriteLine("=== RPG DOS SANTOS LAND ===");
Console.WriteLine("Bem-vindo ao RPG do Santos Land!");
Console.WriteLine("Vamos escolher a sua classe nesse universo: ");
Console.WriteLine("1. Guerreira");
Console.WriteLine("2. Mago");
Console.WriteLine("3. Arqueira");
int escolhaclasse = Convert.ToInt32(Console.ReadLine());

if (escolhaclasse == 1){
Console.WriteLine("Vejo que você escolheu a classe Guerreira, vamos ver suas habilidades: ");
Console.WriteLine("Ataque: Ataque Pesado");
Console.WriteLine("Defesa: Defesa Total");
}

else if (escolhaclasse == 2){
Console.WriteLine("Vejo que você escolheu a classe Mago, vamos ver suas habilidades: ");
Console.WriteLine("Ataque: Bola de Fogo");
Console.WriteLine("Defesa: Escudo de Gelo");
}

else if (escolhaclasse == 3){
Console.WriteLine("Vejo que você escolheu a classe Arqueira, vamos ver suas habilidades: ");
Console.WriteLine("Ataque: Flecha Precisa");
Console.WriteLine("Defesa: Disparo Triplo");
}
else {
Console.WriteLine("Você digitou uma opção inválida, por favor digite um número válido!");
}
}
}