namespace ExerciseMatrix01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("Enter with values for the " + (i+1) + "º row separeted by space.");
                string[] matrixln = Console.ReadLine().Split(' ');

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(matrixln[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Values on the main diagonal: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {                
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            int counter = 0;            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                    
                    if (matrix[i, j] < 0)
                    {                        
                        counter++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Negative values: " + counter);
            Console.WriteLine();

        }
    }
}