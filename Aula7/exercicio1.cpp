using namespace std;
#include <iostream>

int reverso(int numero){
    int numeroinvertido = 0;
    while (numero>0){
        numeroinvertido = numeroinvertido * 10 + (numero%10);
        numero /= 10;
    }
     return numeroinvertido;
}
int main()
{
    int numero;
    cout<<"Digite um número inteiro: " << endl;
    cin>>numero;
    int numeroinvertido = reverso(numero);
    cout<<"O reverso do número digitado é igual a: " << numeroinvertido << endl;
    return 0;
}