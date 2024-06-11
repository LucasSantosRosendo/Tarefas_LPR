using namespace std;
#include <iostream>

int main()
{
    int matriz[4][4] = {
        {0, 524, 521, 882}, 
        {524, 0, 434, 586}, 
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };
    string cidades[4] = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};
    int origem, destino;
    while(1)
    {
        cout<<"Escolhe um destino e uma origem de acordo com os seguintes números: " << endl;
            cout<<"0. Vitória" << endl;
            cout<<"1. Belo Horizonte" << endl;
            cout<<"2. Rio de Janeiro" << endl;
            cout<<"3. São Paulo" << endl;
        cout<<"Digite o número da cidade de origem: " << endl;
        cin>>origem;
        cout<<"Digite o número da cidade de destino: " << endl;
        cin>>destino;
        if (origem == destino) {
            cout << "Origem e destino são iguais! Saindo..." << endl;
            break;
        }
        cout << "A distância entre " << cidades[origem] << " e " << cidades[destino] << " é de " << matriz[origem][destino] << " km." << endl;
    }

    return 0;
}