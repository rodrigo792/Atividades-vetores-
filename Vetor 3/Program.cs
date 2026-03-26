namespace Vetor_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[8];
            bool encontrado = false;

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um valor para buscar: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < 8; i++)
            {
                if (vetor[i] == valor)
                {
                    Console.WriteLine($"Encontrado na posição {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("O número não se encontra no vetor");
        }
    }
}
