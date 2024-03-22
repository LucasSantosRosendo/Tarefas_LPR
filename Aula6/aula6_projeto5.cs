using System;

class HelloWorld {
static void Main() {
float horaspordia, totalsemana, contagemdias, contagemsemanas, contagemMes;
int totalhoras = 1000;
float mes = 4.5f;

Console.WriteLine("=== Centro de Treinamento Jedi ===");
Console.WriteLine("Insira o número de horas de treinamento por dia: ");
horaspordia = float.Parse(Console.ReadLine());

while (horaspordia > 24) {

    
    Console.WriteLine("Por favor, coloque um número menor que 24");
    horaspordia = float.Parse(Console.ReadLine());
    
}

totalsemana = horaspordia * 5;
if (totalsemana < totalhoras) {
Console.WriteLine("Você ainda não alcançou as 1000 horas de treinamento, vamos analisar quanto tempo falta para concluir: ");

if (totalsemana < totalhoras) {
contagemdias = totalhoras / horaspordia - totalsemana;
contagemsemanas = contagemdias / 5;
contagemMes = contagemdias / (5 * 4);

Console.WriteLine($"Dias: Ainda faltam {contagemdias}");
Console.WriteLine($"Semanas: Ainda faltam {contagemsemanas}");
Console.WriteLine($"Meses: Ainda faltam {contagemMes}");
}
} else {
Console.WriteLine("Parabéns! Você concluiu as 1000 horas do treinamento!");
}
}
}