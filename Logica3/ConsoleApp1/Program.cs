//Exercício: Determinar se uma pessoa está apta a dirigir utilizando seu ano de nascimento e ano atual

int AnoNasc, AnoAtual, idade;

Console.Write("Digite seu ano de nascimento(YYYY):");
AnoNasc = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano atual(YYYY):");
AnoAtual = Convert.ToInt32(Console.ReadLine());

idade = AnoAtual - AnoNasc;

if (idade >= 18)
{
    Console.WriteLine("Está apto a tirar a carteira de motorista!");
}
else
{
    Console.WriteLine("Não está apto a tirar a carteira de motorista");
}
Console.WriteLine("---------------------------------------------------------------------------");
//Exercício: Determinar o paroveitamento de um aluno entra A, B, C, D, E ou F

double Nota1, Nota2, Média;

Console.Write("Insira a primera nota:");
Nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira a segunda nota:");
Nota2 = Convert.ToDouble(Console.ReadLine());

Média = (Nota1 + Nota2) / 2;

if (Média == 10 || Média >= 9)
{
    Console.WriteLine("Média:" + Média);
    Console.WriteLine("Aproveitamento: A");
}
else if (Média == 8.9 || Média >= 800)
{
    Console.WriteLine("Média:" + Média);
    Console.WriteLine("Aproveitamento: B");
}
else if (Média == 7.9 || Média >= 7)
{
    Console.WriteLine("Média:" + Média);
    Console.WriteLine("Aproveitamento: C");
}
else if (Média == 6.9 || Média >= 6)
{
    Console.WriteLine("Média:" + Média);
    Console.WriteLine("Aproveitamento: D");
}
else if (Média == 5.9 || Média >= 5)
{
    Console.WriteLine("Média:" + Média);
    Console.WriteLine("Aproveitamento: E");
}
else if (Média < 5)
{
    Console.WriteLine("Média:" + Média);
    Console.WriteLine("Aproveitamento: F");
}

//Imprima na tela o dia da semana utilizando switch/case

int Dia;

Console.Write("digite o dia da semana(1-7):");
Dia = Convert.ToInt32(Console.ReadLine());

switch (Dia)
{
    case 1:
        Console.WriteLine("Hoje é domingo!");
        break;
    case 2:
        Console.WriteLine("Hoje é segunda-feira.");
        break;
    case 3:
        Console.WriteLine("Hoje é terça-feira.");
        break;
    case 4:
        Console.WriteLine("Hoje é quarta-feira.");
                break;
        case 5:
        Console.WriteLine("Hoje é quinta-feira!");
        break;
        case 6:
        Console.WriteLine("Hoje é sexta-feira");
        break;
        case 7:
        Console.WriteLine("Hoje é sábado!");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}
