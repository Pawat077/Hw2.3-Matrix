class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter '+' or '-' to continue, or any other character to exit:");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input != '+' && input != '-')
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            Console.WriteLine("Enter the size of the matrix:");
            int size = int.Parse(Console.ReadLine());

            double[,] matrix = new double[size, size];

            Console.WriteLine("Enter the members of the matrix:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Result:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (input == '+')
                        Console.Write(matrix[i, j] >= 0 ? matrix[i, j] : -matrix[i, j]);
                    else if (input == '-')
                        Console.Write(matrix[i, j] < 0 ? matrix[i, j] : -matrix[i, j]);

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
