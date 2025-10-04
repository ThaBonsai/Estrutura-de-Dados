numero = int(input("Por favor, digite um número entre 1 e 10: "))

while numero < 1 or numero > 10:
    print("Número inválido! Digite um número entre 1 e 10.")
    numero = int(input("Digite um número entre 1 e 10: "))

for i in range(1, numero + 1):
    print(f"2^{i} = {2 ** i}")