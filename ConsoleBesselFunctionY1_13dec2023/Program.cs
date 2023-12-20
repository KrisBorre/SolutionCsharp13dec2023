using LibraryBesselFunction13dec2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Bessel functions!");

        BesselFunctionY1_13dec2023 y1 = new BesselFunctionY1_13dec2023();

        Console.WriteLine("x        y1(x)");

        double x = 0.1;
        Console.WriteLine($"{x}      {y1.Function(x)}");

        for (int i = 1; i <= 14; i++)
        {
            x = (double)i;
            Console.WriteLine($"{i}      {y1.Function(x)}");
        }

        Console.ReadLine();

        /*Hello Bessel functions!
x        y1(x)
0,1      -6,4589510947020266
1      -0,7812128213002887
2      -0,10703243154093822
3      0,3246744247917991
4      0,39792571055709935
5      0,1478631433912262
6      -0,17501034430039844
7      -0,3026672370241848
8      -0,15806046173124744
9      0,1043145751967159
10      0,24901542420695386
11      0,16370553741494262
12      -0,05709921826089674
13      -0,21008140842069356
14      -0,16664484185617215*/

    }
}