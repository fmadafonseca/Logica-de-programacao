//Ler 10 números, somá-los e mostrar o maior número digitado
//usando um loop while
double N, Contagem, Maior, Soma;
Contagem = 1;
Soma = 0;
Maior = 0;
while (Contagem <= 10)
{
    Console.Write("Digite o " + Contagem + "°:");
    N = Convert.ToDouble(Console.ReadLine());
    Soma += N;
    if (N > Maior)
    {
        Maior = N;
    }
    Contagem++;
}
Console.WriteLine("Soma final: " + Soma);
Console.WriteLine("Maior número digitado: " + Maior);
//Usando um loop for
Console.WriteLine("--------------------------------------------------------------------------------------");
Soma = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite o " + i + "°:");
    N = Convert.ToDouble(Console.ReadLine());
    Soma += N;
    if (N > Maior)
    {
        Maior = N;
    }
}
Console.WriteLine("Soma final: " + Soma);
Console.WriteLine("Maior número digitado: " + Maior);