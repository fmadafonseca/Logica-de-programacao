//criar um projeto para identificar se um um número é par ou ímpar

internal class Program
{
    private static void Main(string[] args)
    {
        double numero;

        Console.Write("Digite um número: ");
        numero = double.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine(numero + " é um número par.");
        }
        else
        {
            Console.WriteLine(numero + " é um número ímpar.");
        }


        Console.WriteLine("----------------------------------");
        //criar um programa para cacular o IMC de uma pessoa indicar se ela está no peso ideal(entre 18,5 e 25)

        double massa, altura, imc;

        Console.Write("Digite a sua massa(KG): ");
        massa = double.Parse(Console.ReadLine());

        Console.Write("Digite a sua altura(M): ");
        altura = double.Parse(Console.ReadLine());

        imc = (massa / (altura * 2));

        Console.WriteLine();
        Console.WriteLine("seu IMC é " + imc);
        Console.WriteLine();

        if (imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso ideal.");
        }
        else if (imc > 25)
        {
            Console.WriteLine("Você está acima do peso ideal.");
        }
        else
        {
            Console.WriteLine("Você está no peso ideal");
        }


    }
}

