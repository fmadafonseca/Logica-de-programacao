//Fazer um programa para converter reais em dólares, perguntar ao usúario a cotação e quantas conversões ele deseja fazer

double Cotacao, ValorBRL, ValorUSD;
int Conversoes;

Console.WriteLine("Conversor de reais para dólares");
Console.Write("Quantas conversões deseja fazer? ");
Conversoes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Qual a cotação atual do dólar? ");
Cotacao = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < Conversoes; i++)
{
    Console.Write("Qual o valor em reais a ser convertido? ");
    ValorBRL = Convert.ToDouble(Console.ReadLine());
    ValorUSD = ValorBRL / Cotacao;
    Console.WriteLine("O valor em dólares é:" + ValorUSD.ToString("0.00"));
    Console.WriteLine();
}