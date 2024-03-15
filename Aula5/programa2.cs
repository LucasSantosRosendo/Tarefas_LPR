using System;
class HelloWorld {
static void Main() {
Console.WriteLine("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero %2 == 0){
Console.WriteLine("O número que você digitou é par!");
}
else {
Console.WriteLine("O número que você digitou é ímpar!");
}
}
}