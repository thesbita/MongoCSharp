// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Xml;



using System;
using System.Linq;
using System.Collections.Generic;

public class TAGMedia
{
    public static void Main(string[] args)
    {
        // ex. 1
        double nota1 = 8.00;
        double nota2 = 3.00;

        Console.WriteLine(String.Format("Media das notas {0}",
        (nota1 + nota2) / 2));

        // ex. 2
        int[] ages = { 5, 10, 15, 20, 25 };
        Console.WriteLine(String.Format("Media das idades {0}",
       ages.Sum() / 5));

        // ex. 3
        int parImpar = 4;
        if (parImpar % 2 == 0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }

        // ex. 4
        var numberList = new List<int>() { 19, 16, 22, 1, 9, 17, 21, 65, 6, 18 };
        int maior = 0;
        int menor = numberList.ElementAt(0);
        foreach (var number in numberList)
        {
            if (number > maior)
            {
                maior = number;
            }
            if (number < menor)
            {
                menor = number;
            }
        }
        Console.WriteLine(String.Format("Maior {0} - Menor {1}",
        maior, menor));

        Console.WriteLine(String.Format("Maior {0} - Menor {1}",
        numberList.Max(), numberList.Min()));

        // ex. 5
        Console.WriteLine("Entre com o nome:");

        string nome = Console.ReadLine();

        Console.WriteLine("nome: " + nome);

        // ex. 6
        Console.WriteLine("Entre com o primeiro numero:");
        int primeiroNumero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre com o segundo numero:");
        int segundoNumero = Convert.ToInt32(Console.ReadLine());
        if (primeiroNumero > segundoNumero)
        {
            Console.WriteLine(String.Format("o primeiro numero e maior {0}",
primeiroNumero));
        }
        else
        {
            Console.WriteLine(String.Format("o segundo numero e maior {0}",
        segundoNumero));
        }

        // ex. 7
        Console.WriteLine("Entre com o texto:");
        string texto = Console.ReadLine();
        bool contemA = false;

        foreach (char caractere in texto)
        {
            if (caractere == 'a')
            {
                contemA = true;
                break;
            }
        }

        if (contemA)
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Nao");
        }

        if (texto.ToLower().Contains('a'))
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Nao");
        }

        // ex. 8
        var fruitList = new List<string>() { "banana", "morango", "limao" };
        foreach (string fruit in fruitList)
        {
            switch (fruit)
            {
                case "banana":
                    Console.WriteLine("fruta amarela");
                    break;
                case "morango":
                    Console.WriteLine("fruta vermelha");
                    break;
                case "limao":
                    Console.WriteLine("fruta verde");
                    break;
            }
        }

        // ex. 9
        Console.WriteLine("Entre com o salario:");
        int salario = Convert.ToInt32(Console.ReadLine());
        double reajuste = 0.35 * salario;
        double valorFinal = reajuste + salario;
        Console.WriteLine(String.Format("o valor do salario com reajuste sera {0}", valorFinal));

        // ex. 10
        var ageList = new List<int>() { 19, 16, 22, 1, 9, 17, 21, 65, 6, 18 };
        int greaterThan20 = 0;
        foreach (var age in ageList)
        {
            if (age > 20)
            {
                greaterThan20++;
            }
        }
        Console.WriteLine(String.Format("{0} pessoas tem mais de 20 anos", greaterThan20));

    }
}









