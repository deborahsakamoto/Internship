using System.Globalization;

namespace ExerciseCreateMenuStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, row, col, min, n = 0;
            double opt1, opt2, aux, sum = 0;
            double[] vec1, vec2;
            double[,] mat1, mat2;

            Console.WriteLine("Which structure do you want to assemble?");
            Console.WriteLine("[1] Vector");
            Console.WriteLine("[2] Matrix");
            Console.WriteLine();
            opt1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            do
            {


                if (opt1 == 1)
                {
                    Console.WriteLine("You chose Vector");
                    Console.WriteLine();
                    Console.WriteLine("What is the size of the vector?");
                    size = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    vec1 = new double[size];
                    vec2 = new double[size];

                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Inform the " + (i + 1) + " value of the first vector: ");
                        vec1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                    Console.WriteLine("[1] Add the vectors");
                    Console.WriteLine("[2] Subtract the vectors");
                    Console.WriteLine("[3] Sort the vectors");
                    Console.WriteLine("[4] Find the arithmetic mean");
                    Console.WriteLine();
                    opt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (opt2 == 1)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine("Inform the " + (i + 1) + " value of the second vector: ");
                            vec2[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("You chose to add the vectors");
                        Console.WriteLine();

                        Console.WriteLine("V1       V2       V3");
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine(vec1[i] + "   +   " + vec2[i] + "   =   " + (vec1[i] + vec2[i]));
                        }
                    }
                    else if (opt2 == 2)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine("Inform the " + (i + 1) + " value of the second vector: ");
                            vec2[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("You chose to subtract the vectors");

                        Console.WriteLine("V1       V2       V3");
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine(vec1[i] + "    -    " + vec2[i] + "    =    " + (vec1[i] - vec2[i]));
                        }
                    }
                    else if (opt2 == 3)
                    {
                        Console.WriteLine("You chose to sort the vector");
                        Console.WriteLine();
                        Console.WriteLine("The vector you typed");

                        for (int i = 0; i < size; i++)
                        {
                            Console.Write(vec1[i] + " ");
                        }
                        Console.WriteLine();

                        for (int i = 0; i < size - 1; i++)
                        {
                            min = i;
                            for (int j = i + 1; j < size; j++)
                            {
                                if (vec1[j] < vec1[min])
                                {
                                    min = j;
                                }
                            }
                            if (min != i)
                            {
                                aux = vec1[min];
                                vec1[min] = vec1[i];
                                vec1[i] = aux;
                            }
                        }

                        Console.WriteLine("The ordered vector:");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write(vec1[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    else if (opt2 == 4)
                    {
                        Console.WriteLine("You chose to find the arithmetic mean");

                        for (int i = 0; i < size; i++)
                        {
                            sum += vec1[i];
                        }
                        sum /= size;

                        Console.WriteLine("The arithmetic mean of the vector is: " + sum.ToString("f2", CultureInfo.InvariantCulture));

                    }

                }
                else if (opt1 == 2)
                {
                    Console.WriteLine("You chose Matrix");
                    Console.WriteLine();
                    Console.WriteLine("How many rows does your matrix have");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("How many columns does your matrix have");
                    col = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    mat1 = new double[row, col];
                    mat2 = new double[row, col];

                    for (int i = 0; i < row; i++)
                    {
                        Console.WriteLine("Enter a value for the " + (i + 1) + "º row of first matrix (separeted by SPACE):");
                        string[] vect = Console.ReadLine().Split(' ');

                        for (int j = 0; j < col; j++)
                        {
                            mat1[i, j] = int.Parse(vect[j]);
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine();
                    Console.WriteLine("[1] Add the matrix");
                    Console.WriteLine("[2] Subtract the matrix");
                    Console.WriteLine("[3] Sort the matrix");
                    Console.WriteLine("[4] Find the arithmetic mean");
                    Console.WriteLine();
                    opt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (opt2 == 1)
                    {
                        Console.WriteLine("You chose to add the vectors");
                        Console.WriteLine();

                        for (int i = 0; i < row; i++)
                        {
                            Console.WriteLine("Enter a value for the " + (i + 1) + "º row of second matrix (separeted by SPACE):");
                            string[] vect = Console.ReadLine().Split(' ');

                            for (int j = 0; j < col; j++)
                            {
                                mat2[i, j] = int.Parse(vect[j]);
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Matrix 1 + Matrix 2:");

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write((mat1[i, j] + mat2[i, j]) + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    else if (opt2 == 2)
                    {
                        Console.WriteLine("You chose to subtract the vectors");
                        Console.WriteLine();

                        for (int i = 0; i < row; i++)
                        {
                            Console.WriteLine("Enter a value for the " + (i + 1) + "º row of second matrix (separeted by SPACE):");
                            string[] vect = Console.ReadLine().Split(' ');

                            for (int j = 0; j < col; j++)
                            {
                                mat2[i, j] = int.Parse(vect[j]);
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Matrix 1 - Matrix 2:");

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write((mat1[i, j] - mat2[i, j]) + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    else if (opt2 == 3)
                    {
                        Console.WriteLine("You chose to sort the vector");
                        Console.WriteLine();
                        Console.WriteLine("The matrix you typed");

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write(mat1[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        vec1 = new double[(row * col)];

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                vec1[n] = mat1[i, j];
                                n++;
                            }
                        }
                        n = 0;

                        for (int i = 0; i < (row * col) - 1; i++)
                        {
                            min = i;
                            for (int j = i + 1; j < (row * col); j++)
                            {
                                if (vec1[j] < vec1[min])
                                {
                                    min = j;
                                }
                            }
                            if (min != i)
                            {
                                aux = vec1[min];
                                vec1[min] = vec1[i];
                                vec1[i] = aux;
                            }
                        }

                        Console.WriteLine("The ordered matrix:");
                        for (int i = 0; i < (row*col); i++)
                        {
                            Console.Write(vec1[i] + " ");
                            if ((i+1) % col == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (opt2 == 4)
                    {
                        Console.WriteLine("You chose to find the arithmetic mean");
                        sum = 0;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                sum += mat1[i, j];
                            }
                        }
                        sum /= (row*col);

                        Console.WriteLine("The arithmetic mean of the vector is: " + sum);

                    }
                }

                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Which structure do you want to assemble?");
                Console.WriteLine("[1] Vector");
                Console.WriteLine("[2] Matrix");
                Console.WriteLine();
                opt1 = int.Parse(Console.ReadLine());
                Console.WriteLine();



            } while (opt1 != 1 || opt1 != 2);

            Console.WriteLine("Thank you for using our services");
        }
    }
}