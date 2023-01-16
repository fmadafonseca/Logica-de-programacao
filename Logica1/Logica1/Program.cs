//Aula de lógica de programação 1, criar um programa para testar o tipo de triângulo e se é possível formar um triângulo
internal class Program
{
    static void Main(string[] args)
    {
        double L1, L2, L3;
        bool EQ, ES, IS, TRI;

        Console.Write("Digite o primeiro lado: ");
        L1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo lado: ");
        L2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o terceiro lado: ");
        L3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        TRI = (L1 < L2 + L3) && (L2 < L1 + L3) && (L3 < L1 + L2);
        if (TRI == true)
        {

            EQ = (L1 == L2) && (L2 == L3);
            ES = (L1 != L2) && (L2 != L3) && (L1 != L3);
            IS = (L1 == L2 && L2 != L3) || (L2 == L3 && L2 != L3) || (L1 == L3 && L3 != L2);
            Console.WriteLine("Pode formar um triângulo? " + TRI);
            Console.WriteLine("O triângulo é equilatero? " + EQ);
            Console.WriteLine("O triângulo é escaleno? " + ES);
            Console.WriteLine("O triângulo é Isosceles? " + IS);
        }
        else
        {
            Console.WriteLine("Não pode formar um triângulo.");
        }















    }
}