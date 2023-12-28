using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, MathNet.Numerics!");

        var A = Matrix<double>.Build.DenseOfArray(new double[,] {
    { 3, 2, -1 },
    { 2, -2, 4 },
    { -1, 0.5, -1 }
});
        var b = Vector<double>.Build.Dense(new double[] { 1, -2, 0 });
        var x = A.Solve(b);

        Console.WriteLine($"x={x}");

        double x2 = SpecialFunctions.Factorial(14); // 87178291200.0
        double y2 = SpecialFunctions.Factorial(31); // 8.2228386541779224E+33
        double erf = SpecialFunctions.Erf(0.9); // 0.7969082124

        Console.WriteLine();

        /*
         x=DenseVector 3-Double
 1
-2
-2
*/
    }
}