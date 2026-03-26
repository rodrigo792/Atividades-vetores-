namespace Vetor_6
{
    internal class Program
    {
        static void Main()
        {
            double[] salarios = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Salário {i + 1}: ");
                salarios[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Salários reajustados:");

            for (int i = 0; i < 10; i++)
            {
                salarios[i] *= 1.05;
                Console.WriteLine($"R$ {salarios[i]:F2}");
            }
        }
    }
}
