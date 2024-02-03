namespace ConsoleStelselOplosser28dec2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Het oplossen van een stelsel van lineaire vergelijkingen door middel van Gauss-Jordan eliminatie.");
            // https://nl.wikipedia.org/wiki/Stelsel_van_lineaire_vergelijkingen
            // https://nl.wikipedia.org/wiki/Gauss-Jordaneliminatie

            #region problem1
            {
                Console.WriteLine("Probleem 1");

                int n = 3;
                double[,] a = new double[n, n];

                a[0, 0] = 1.0; a[0, 1] = 0.0; a[0, 2] = 0.0;
                a[1, 0] = 0.0; a[1, 1] = 2.0; a[1, 2] = 0.0;
                a[2, 0] = 0.0; a[2, 1] = 0.0; a[2, 2] = 3.0;

                int aantalRijen = a.GetLength(0);
                int aantalKolommen = a.GetLength(1);

                // We lossen 2 verschillende inhomogene stelsels op.
                int m = 2;
                double[,] b = new double[n, m];

                b[0, 0] = 1.0;
                b[1, 0] = 0.0;
                b[2, 0] = 0.0;

                b[0, 1] = 1.0;
                b[1, 1] = 1.0;
                b[2, 1] = 1.0;

                StelselOplosser stelselOplosser = new StelselOplosser();

                // copy the matrix a to ai and then let Gaussj overwrite ai
                double[,] ai = new double[n, n];
                for (int k = 0; k < a.GetLength(0); k++)
                {
                    for (int l = 0; l < a.GetLength(1); l++)
                    {
                        ai[k, l] = a[k, l];
                    }
                }

                // copy the matrix b to x and then let Gaussj overwrite x
                double[,] x = new double[n, m];
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    for (int l = 0; l < b.GetLength(1); l++)
                    {
                        x[k, l] = b[k, l];
                    }
                }

                stelselOplosser.Gaussj(ai, x);

                Console.WriteLine("matrix a : ");
                WriteMatrix(a);

                Console.WriteLine("Inverse of matrix a : ");
                WriteMatrix(ai);

                Console.WriteLine("Check inverse!");
                Console.WriteLine("a times a-inverse:");
                double[,] u = MultiplyMatrices(a, ai);
                WriteMatrix(u);

                Console.WriteLine("Check vector solutions!");
                CheckSolutions(a, b, x);

                /*Probleem 1
                matrix a :
                1            0            0
                0            2            0
                0            0            3

                Inverse of matrix a :
                1            0            0
                0            0,5            0
                0            0            0,333333

                Check inverse!
                a times a-inverse:
                1            0            0
                0            1            0
                0            0            1

                Check vector solutions!
                Check the following for equality:
                original                 matrix*sol'n
                vector 0:
                     1                        1
                     0                        0
                     0                        0
                vector 1:
                     1                        1
                     1                        1
                     1                        1
                */
            }
            #endregion

            Console.WriteLine();

            #region problem2
            {
                Console.WriteLine("Probleem 2");

                int n = 3;

                double[,] a = new double[n, n];

                a[0, 0] = 1.0; a[0, 1] = 2.0; a[0, 2] = 3.0;
                a[1, 0] = 1.0; a[1, 1] = -2.0; a[1, 2] = 3.0;
                a[2, 0] = 1.0; a[2, 1] = 2.0; a[2, 2] = -3.0;

                // We lossen 2 verschillende inhomogene stelsels op.
                int m = 2;
                double[,] b = new double[n, m];

                b[0, 0] = 1.0;
                b[1, 0] = 1.0;
                b[2, 0] = 1.0;

                b[0, 1] = 1.0;
                b[1, 1] = 2.0;
                b[2, 1] = 3.0;

                StelselOplosser stelselOplosser = new StelselOplosser();

                // copy the matrix a to ai and then let Gaussj overwrite ai
                double[,] ai = new double[n, n];
                for (int k = 0; k < a.GetLength(0); k++)
                {
                    for (int l = 0; l < a.GetLength(1); l++)
                    {
                        ai[k, l] = a[k, l];
                    }
                }

                // copy the matrix b to x and then let Gaussj overwrite x
                double[,] x = new double[n, m];
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    for (int l = 0; l < b.GetLength(1); l++)
                    {
                        x[k, l] = b[k, l];
                    }
                }

                stelselOplosser.Gaussj(ai, x);

                Console.WriteLine("matrix a : ");
                WriteMatrix(a);

                Console.WriteLine("Inverse of matrix a : ");
                WriteMatrix(ai);

                Console.WriteLine("Check inverse!");
                Console.WriteLine("a times a-inverse:");
                double[,] u = MultiplyMatrices(a, ai);
                WriteMatrix(u);

                Console.WriteLine("Check vector solutions!");
                CheckSolutions(a, b, x);

                /*Probleem 2
                matrix a :
                1            2            3
                1            -2            3
                1            2            -3

                Inverse of matrix a :
                0            0,5            0,5
                0,25            -0,25            0
                0,166667            0            -0,166667

                Check inverse!
                a times a-inverse:
                1            0            0
                0            1            0
                0            0            1

                Check vector solutions!
                Check the following for equality:
                original                 matrix*sol'n
                vector 0:
                     1                        1
                     1                        1
                     1                        1
                vector 1:
                     1                        1
                     2                        2
                     3                        3
                */
            }
            #endregion

            Console.WriteLine();

            #region problem3
            {
                Console.WriteLine("Probleem 3");

                int n = 5;

                double[,] a = new double[n, n];

                a[0, 0] = 1.0; a[0, 1] = 2.0; a[0, 2] = 3.0; a[0, 3] = 4.0; a[0, 4] = 5.0;
                a[1, 0] = 2.0; a[1, 1] = 3.0; a[1, 2] = 4.0; a[1, 3] = 5.0; a[1, 4] = 1.0;
                a[2, 0] = 3.0; a[2, 1] = 4.0; a[2, 2] = 5.0; a[2, 3] = 1.0; a[2, 4] = 2.0;
                a[3, 0] = 4.0; a[3, 1] = 5.0; a[3, 2] = 1.0; a[3, 3] = 2.0; a[3, 4] = 3.0;
                a[4, 0] = 5.0; a[4, 1] = 1.0; a[4, 2] = 2.0; a[4, 3] = 3.0; a[4, 4] = 4.0;

                // We lossen 2 verschillende inhomogene stelsels op.
                int m = 2;
                double[,] b = new double[n, m];

                b[0, 0] = 1.0;
                b[1, 0] = 1.0;
                b[2, 0] = 1.0;
                b[3, 0] = 1.0;
                b[4, 0] = 1.0;

                b[0, 1] = 1.0;
                b[1, 1] = 2.0;
                b[2, 1] = 3.0;
                b[3, 0] = 4.0;
                b[4, 0] = 5.0;

                StelselOplosser stelselOplosser = new StelselOplosser();

                // copy the matrix a to ai and then let Gaussj overwrite ai
                double[,] ai = new double[n, n];
                for (int k = 0; k < a.GetLength(0); k++)
                {
                    for (int l = 0; l < a.GetLength(1); l++)
                    {
                        ai[k, l] = a[k, l];
                    }
                }

                // copy the matrix b to x and then let Gaussj overwrite x
                double[,] x = new double[n, m];
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    for (int l = 0; l < b.GetLength(1); l++)
                    {
                        x[k, l] = b[k, l];
                    }
                }

                stelselOplosser.Gaussj(ai, x);

                Console.WriteLine("matrix a : ");
                WriteMatrix(a);

                Console.WriteLine("Inverse of matrix a : ");
                WriteMatrix(ai);

                Console.WriteLine("Check inverse!");
                Console.WriteLine("a times a-inverse:");
                double[,] u = MultiplyMatrices(a, ai);
                WriteMatrix(u);

                Console.WriteLine("Check vector solutions!");
                CheckSolutions(a, b, x);

                /*Probleem 3
                matrix a :
                1            2            3            4            5
                2            3            4            5            1
                3            4            5            1            2
                4            5            1            2            3
                5            1            2            3            4

                Inverse of matrix a :
                -0,186667            0,013333            0,013333            0,013333            0,213333
                0,013333            0,013333            0,013333            0,213333            -0,186667
                0,013333            0,013333            0,213333            -0,186667            0,013333
                0,013333            0,213333            -0,186667            0,013333            0,013333
                0,213333            -0,186667            0,013333            0,013333            0,013333

                Check inverse!
                a times a-inverse:
                1            0            -0            0            -0
                0            1            0            -0            -0
                -0            -0            1            0            -0
                -0            -0            0            1            0
                -0            -0            0            0            1

                Check vector solutions!
                Check the following for equality:
                original                 matrix*sol'n
                vector 0:
                     1                        1
                     1                        1
                     1                        1
                     4                        4
                     5                        5
                vector 1:
                     1                        1
                     2                        2
                     3                        3
                     0                        -0
                     0                        -0
                */
            }
            #endregion

            Console.WriteLine();
        }


        private static void WriteMatrix(double[,] matrix)
        {
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++) Console.Write($"{Math.Round(matrix[k, l], 6)}            ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            double[,] result = null;
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int rows = matrix1.GetLength(0);
                int columns = matrix2.GetLength(1);
                result = new double[rows, columns];

                for (int k = 0; k < rows; k++)
                {
                    for (int l = 0; l < columns; l++)
                    {
                        result[k, l] = 0.0;
                        for (int j = 0; j < matrix1.GetLength(1); j++)
                        {
                            result[k, l] += (matrix1[k, j] * matrix2[j, l]);
                        }

                    }
                }
            }
            return result;
        }

        private static void CheckSolutions(double[,] matrix, double[,] vectors, double[,] solutions)
        {
            int n = vectors.GetLength(0);
            int m = vectors.GetLength(1);
            double[,] t = new double[n, m];
            Console.WriteLine("Check the following for equality:");
            Console.WriteLine("original                 matrix*sol'n");
            for (int l = 0; l < m; l++)
            {
                Console.WriteLine($"vector {l}: ");
                for (int k = 0; k < n; k++)
                {
                    t[k, l] = 0.0;
                    for (int j = 0; j < n; j++)
                    {
                        t[k, l] += (matrix[k, j] * solutions[j, l]);
                    }
                    Console.WriteLine($"     {vectors[k, l]}                        {Math.Round(t[k, l], 6)}");
                }
            }
        }


    }
}