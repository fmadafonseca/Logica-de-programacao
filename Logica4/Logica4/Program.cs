// Faça um contador que imprima contagens na tela

int contadorInicio, contadorFim;

Console.Write("Digite o primeiro número da contagem:");
contadorInicio = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o último número da contagem:");
contadorFim = Convert.ToInt32(Console.ReadLine());

if (contadorInicio > contadorFim)
{
    while (contadorInicio >= contadorFim)
    {
        Console.WriteLine(contadorInicio);
        contadorInicio--;
    }
}
else if (contadorInicio <= contadorFim)
{
    while (contadorInicio <= contadorFim)
    {
        Console.WriteLine(contadorInicio);
        contadorInicio++;
    }
}

Console.WriteLine("----------------------------------------------------------");
//Faça um contador for para imprimir na tela 0-10 e 10-0

Console.WriteLine("Contagem de 0 a 10");

int contagemFinal;
contagemFinal = 10;

for (int i = 0; i <= contagemFinal; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Contagem de 10 até 0");

contagemFinal = 0;

for(int i = 10;i >= contagemFinal; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------------------------------------------------------");
//Faça um contador for para imprimir na tela de 0 até o valor digitado pelo usuário

Console.Write("Contar até qual número?");
contagemFinal = Convert.ToInt32(Console.ReadLine());

for (int i = 0;i <= contagemFinal; i++)
{
    Console.WriteLine(i);
}