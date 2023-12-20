using LibraryBesselFunction13dec2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Bessel functions!");

        BesselFunctionY0_13dec2023 y0 = new BesselFunctionY0_13dec2023();

        Console.WriteLine("x        y0(x)");

        double x = 0.1;
        Console.WriteLine($"{x}      {y0.Function(x)}");

        for (int i = 1; i <= 14; i++)
        {
            x = (double)i;
            Console.WriteLine($"{i}      {y0.Function(x)}");
        }

        Console.ReadLine();

        /*Hello Bessel functions!
x        y0(x)
0,1      -1,5342386513503667
1      0,08825696421567715
2      0,5103756726497445
3      0,37685001001278995
4      -0,016940739325065346
5      -0,30851762524903426
6      -0,2881946839815793
7      -0,02594974396720945
8      0,22352148938756625
9      0,24993669828502474
10      0,05567116728359959
11      -0,1688473238920794
12      -0,22523731263436145
13      -0,07820786452787606
14      0,12719256858218353*/
    }
}