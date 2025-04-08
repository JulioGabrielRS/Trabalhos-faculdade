using System;

class Program 
{
    public static int BuscarComSentinela(int[] array, int elemento)
    {
        if (array == null || array.Length == 0)
        {
            return -1;
        }

        int ultimoElemento = array[array.Length - 1];

        array[array.Length - 1] = elemento;

        int i = 0;
        while (array[i] != elemento)
        {
            i++;
        }

        array[array.Length - 1] = ultimoElemento;

        if (i < array.Length - 1 || elemento == ultimoElemento)
        {
            return i;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int elementoProcurado = 30;

        int[] copiaNumeros = (int[])numeros.Clone();

        int indice = BuscarComSentinela(copiaNumeros, elementoProcurado);

        if (indice != -1)
        {
            Console.WriteLine($"Elemento {elementoProcurado} encontrado no índice {indice}");
        }
        else
        {
            Console.WriteLine($"Elemento {elementoProcurado} não encontrado no array");
        }
    }
}