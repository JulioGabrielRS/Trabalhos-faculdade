class Program
{
    static void Main()
    {
        double[] alturas = { 1.98, 1.73, 2.05, 1.78, 1.25 };
        char[] sexos = { 'M', 'F', 'F', 'M', 'M' };

        double menor = alturas.Min();
        double maior = alturas.Max();
        var alturasMulheres = alturas.Where((alt, i) => sexos[i] == 'F').ToArray();
        double mediaMulheres = alturasMulheres.Average();
        int numHomens = sexos.Count(s => s == 'M');

        Console.WriteLine($"Menor altura = {menor}");
        Console.WriteLine($"Maior altura = {maior}");
        Console.WriteLine($"Media das alturas das mulheres = {mediaMulheres}");
        Console.WriteLine($"Numero de homens = {numHomens}");
    }
}