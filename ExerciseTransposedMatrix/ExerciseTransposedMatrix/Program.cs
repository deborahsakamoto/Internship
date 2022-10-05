namespace ExerciseTransposedMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[m,n];
            int[,] matrix2 = new int[n,m];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                Console.WriteLine("Enter a value for the "+ (i+1) +"º row separeted by SPACE:");
                string[] vect = Console.ReadLine().Split(' ');

                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = int.Parse(vect[j]);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix2[j, i] = matrix1[i,j];
                }               
            }

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}