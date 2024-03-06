using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numeroInformado = int.Parse(Console.ReadLine());

        if (PertenceSequenciaFibonacci(numeroInformado))
        {
            Console.WriteLine($"O número {numeroInformado} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numeroInformado} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceSequenciaFibonacci(int numero)
    {
        int a = 0, b = 1;

        while (a <= numero)
        {
            if (a == numero)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
