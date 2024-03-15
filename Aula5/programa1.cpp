#include <iostream>
int main()
{
int numero1, numero2;

std::cout<<"Digite um primeiro número inteiro: ";
std::cin>>numero1;
std::cout<<"Digite um segundo número inteiro: ";
std::cin>>numero2;

if ((numero1%numero2 == 0) | (numero2%numero1 == 0)){
std::cout<<"Os número digitados são múltiplos!";
}
else {
std::cout<<"Os números digitados não são múltiplos!";
}


return 0;
}