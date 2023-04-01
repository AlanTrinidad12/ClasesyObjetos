using System;

class ClasesyObjetos
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];

        // Pedir al usuario que ingrese los 10 números
        Console.WriteLine("Ingrese 10 números:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Calcular la media
        double suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += numeros[i];
        }
        double media = suma / 10;
        Console.WriteLine($"La media es: {media}");

        // Calcular la mediana
        Array.Sort(numeros);
        double mediana;
        if (numeros.Length % 2 == 0)
        {
            mediana = (numeros[numeros.Length / 2] + numeros[numeros.Length / 2 - 1]) / 2.0;
        }
        else
        {
            mediana = numeros[numeros.Length / 2];
        }
        Console.WriteLine($"La mediana es: {mediana}");

        // Calcular la moda
        int moda = 0;
        int repeticiones = 0;
        for (int i = 0; i < 10; i++)
        {
            int contador = 0;
            for (int j = 0; j < 10; j++)
            {
                if (numeros[j] == numeros[i])
                {
                    contador++;
                }
            }
            if (contador > repeticiones)
            {
                moda = numeros[i];
                repeticiones = contador;
            }
        }
        Console.WriteLine($"La moda es: {moda}");
    }
}