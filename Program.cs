// Escreva a mensagem "Informe um numero: "
Console.Write("Informe um numero: ");
// Cria a variável variavelQueSalvaUmNumero, 
// leia o que o usuário digitar
// e tranforma o valor lido de texto para inteiro (int.Parse)
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

// verifica se o valor de variavelQueSalvaUmNumero é par
if (variavelQueSalvaUmNumero % 2 == 0) {
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é par");
} else {
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é ímpar");
}