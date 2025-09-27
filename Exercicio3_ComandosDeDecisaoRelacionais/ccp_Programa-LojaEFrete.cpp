#include <iostream>
using namespace std;

int main() 
{
    double valorcompra;
    cout << "digite o valor da compra \n";
    cin >> valorcompra;
    
    if (valorcompra >= 150) {
      cout << "Frete Grátis!";
    }
    
    else {
      valorcompra = valorcompra + 15;
      cout << "Valor da compra com frete: " << valorcompra <<endl;
    }
    return 0;
}