using namespace std;
#include <iostream>

void exercicio1(){
    int soma = 0;
    float media;
    cout << "Digite a quantidade de números fornecidos: ";
    int quantidade;
    cin >> quantidade;
    int quantidade2 = quantidade;
    while(quantidade > 0) {
        int contagem;
        cin >> contagem;
        if (contagem % 2 == 0) {
            soma += contagem;
        }
        quantidade--;
    }
    media = soma /quantidade2;
    cout << "O resultado dessa operação é igual a: " << media << endl;
}

void exercicio3(){
    int somaNumeros = 0;
    for (int numero = 50; numero <= 500; numero++) {
        if (numero % 2 != 0 && numero % 3 == 0) {
            somaNumeros += numero;
        }
    }
    cout << "A soma de todos os números ímpares múltiplos de 3 que se encontram no conjunto dos números de 50 a 500 é: " << endl;
    cout << "Soma: " << somaNumeros << endl;
}

void exercicio5(){
    float horaspordia, totalsemana, contagemdias, contagemsemanas, contagemMes;
    int totalhoras = 1000;
    float mes = 4.5f;

    cout << "=== Centro de Treinamento Jedi ===" << endl;
    cout << "Insira o número de horas de treinamento por dia: ";
    cin >> horaspordia;

    while (horaspordia > 24) {
        cout << "Por favor, coloque um número menor que 24" << endl;
        cin >> horaspordia;
    }

    totalsemana = horaspordia * 5;

    if (totalsemana < totalhoras) {
        cout << "Você ainda não alcançou as 1000 horas de treinamento, vamos analisar quanto tempo falta para concluir: " << endl;

        if (totalsemana < totalhoras) {
            contagemdias = totalhoras / horaspordia - totalsemana;
            contagemsemanas = contagemdias / 5;
            contagemMes = contagemdias / (5 * 4);

            cout << "Dias: Ainda faltam " << contagemdias << endl;
            cout << "Semanas: Ainda faltam " << contagemsemanas << endl;
            cout << "Meses: Ainda faltam " << contagemMes << endl;
        }
    } else {
        cout << "Parabéns! Você concluiu as 1000 horas do treinamento!" << endl;
    }
}

int main()
{
    int opcao;
    cout<<"=== Menu de Códigos ===" << endl;
    cout<<"Digite o número do correspondente ao exercício que deseja executar: " << endl;
    cout<<"1. Exercício 1" << endl;
    cout<<"2. Exercício 3" << endl;
    cout<<"3. Exercício 5" << endl;
    cin>>opcao;
    
    switch(opcao){
        case 1:
        exercicio1();
        break;
        case 2:
        exercicio3();
        break;
        case 3:
        exercicio5();
        break;
        default:
        cout<<"Opção inválida!" << endl;
        break;
    }

    return 0;
}