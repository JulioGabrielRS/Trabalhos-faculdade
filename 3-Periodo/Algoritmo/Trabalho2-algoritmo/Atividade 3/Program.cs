class Program
{
    static void Main()
    {
        int[] A = { 4, 3, 09, 12, 17, 40 };
        int[] B = { 8, 25, 4, 9, 35, 45 };
        int[] C = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            C[i] = A[i] + B[i];
        }

        Console.WriteLine("Vetor C: " + string.Join(" ", C));
    }
}