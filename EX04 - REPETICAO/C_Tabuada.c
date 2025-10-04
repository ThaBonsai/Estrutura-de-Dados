#include <stdio.h>
int main()
{
  int numero;
  
  printf("Por favor digite um número\n");
  scanf("%d", &numero);
  for (int tabuada = 1; tabuada <10; tabuada++) {
    printf("%d\n", numero*tabuada);
    
  }
  

return 0;
}