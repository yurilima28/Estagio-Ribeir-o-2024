using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string inputString = Console.ReadLine();

        string invertedString = InverterString(inputString);

        Console.WriteLine($"String original: {inputString}");
        Console.WriteLine($"String invertida: {invertedString}");
    }

    static string InverterString(string original)
    {
        char[] caracteres = original.ToCharArray();
        int inicio = 0;
        int fim = original.Length - 1;

        while (inicio < fim)
        {
           
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

           
            inicio++;
            fim--;
        }

       
        return new string(caracteres);
    }
}
