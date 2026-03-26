namespace Vetor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números positivos:");
            foreach (int num in vetor)
            {
                if (num > 0)
                    Console.WriteLine(num);
            }
        }
    }
}
