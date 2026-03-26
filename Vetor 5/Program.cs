namespace Vetor_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[20];
            int pares = 0, impares = 0, maior50 = 0, menor7 = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                    pares++;
                else
                    impares++;

                if (vetor[i] > 50)
                    maior50++;

                if (vetor[i] < 7)
                    menor7++;
            }

            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Ímpares: " + impares);
            Console.WriteLine("Maiores que 50: " + maior50);
            Console.WriteLine("Menores que 7: " + menor7);
        }
    }
}
