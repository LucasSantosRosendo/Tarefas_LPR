#include <iostream>
using namespace std;

int main() {
    int a[3][3], b[3][3], resultado[3][3];

    
    cout << "Digite a matriz A de 9 valores:" << endl;
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            cin >> a[linha][coluna];
        }
    }
    
    
    cout << "Digite a matriz B de 9 valores:" << endl;
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            cin >> b[linha][coluna];
        }
    }

   
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            resultado[linha][coluna] = 0;
            for (int k = 0; k < 3; k++) {
                resultado[linha][coluna] += a[linha][k] * b[k][coluna];
            }
        }
    }

    
    cout << "A matriz da multiplicação a * b é:" << endl;
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            cout << resultado[linha][coluna] << " ";
        }
        cout << endl;
    }

    return 0;
}