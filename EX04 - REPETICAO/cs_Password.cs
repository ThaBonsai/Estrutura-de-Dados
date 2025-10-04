using System;
 
class Programa {
    static void Main() {
        string senhaCorreta = "1234";
        string senhaDigitada;
 
        do {
            Console.Write("Digite a senha: ");
            senhaDigitada = Console.ReadLine();
 
            if (senhaDigitada != senhaCorreta) {
                Console.WriteLine("Senha incorreta!");
            }
 
        } while (senhaDigitada != senhaCorreta);
 
        Console.WriteLine("Senha correta!");
    }
}