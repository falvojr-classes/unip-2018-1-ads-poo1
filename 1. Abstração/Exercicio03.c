#include <stdio.h>

int main() {
    float saldo;
    
    saldo = 100;
    saldo = saldo - 10;
    saldo = saldo - 50;
    saldo = saldo + 10;
    printf("%.2f", saldo);

    return 0;
}
