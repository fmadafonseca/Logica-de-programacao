//Criar um programa que conte progressivamente ou regressivamente de um número inteiro a outro

int Inicio, Fim;

Console.Write("Início da contagem: ");
Inicio = Convert.ToInt32(Console.ReadLine());
Console.Write("Final da contagem: ");
Fim = Convert.ToInt32(Console.ReadLine());

if (Inicio < Fim)
{
    for (int i = Inicio; i <= Fim; i++)
    {
        Console.Write(i + "..");
    }
}
else
{
    for (int i = Inicio; i >= Fim; i--)
    {
        Console.Write(i + "..");
    }
}
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
//Crie um programa para receber o número de alunos em uma classe, nomes, notas e melhor nota da classe

int NumeroAlunos;
double Nota, MaiorNota;
string NomeAluno, MelhorAluno;
MaiorNota = 0;
MelhorAluno = "0";

Console.Write("Qual o número de alunos na turma:");
NumeroAlunos = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < NumeroAlunos; i++)
{
    Console.Write("nome:");
    NomeAluno = Console.ReadLine();
    Console.Write("Nota:");
    Nota = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    if (Nota > MaiorNota)
    {
        MelhorAluno = NomeAluno;
        MaiorNota = Nota;
    }
}

Console.WriteLine("O melhor aluno foi:" + MelhorAluno);
Console.WriteLine("Com a nota:" + MaiorNota);