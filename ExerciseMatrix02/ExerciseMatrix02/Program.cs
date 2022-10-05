namespace ExerciseMatrix02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a comma-separeted position: ");
            string[] vect = Console.ReadLine().Split(',');
            int m = int.Parse(vect[0]);
            int n = int.Parse(vect[1]);

            int[,] matrix = new int[m, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("Enter with values for the " + (i + 1) + "º row separeted by space.");
                string[] matrixln = Console.ReadLine().Split(' ');

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(matrixln[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Enter a value contained in the array: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == value)
                    {
                        Console.WriteLine("Position " +i+ "," +j+ ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        if (j < matrix.GetLength(1)-1)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        if (i < matrix.GetLength(0)-1)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }     
        }
    }
}