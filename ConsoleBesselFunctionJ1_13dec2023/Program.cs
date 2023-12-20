using LibraryBesselFunction13dec2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Bessel functions!");

        BesselFunctionJ1_13dec2023 j1 = new BesselFunctionJ1_13dec2023();

        Console.WriteLine("x        j1(x)");
        for (int i = -5; i <= 14; i++)
        {
            double x = (double)i;
            Console.WriteLine($"{i}      {j1.Function(x)}");
        }

        Console.ReadLine();

        /*Hello Bessel functions!
x        j1(x)
-5      0,3275791375914654
-4      0,06604332802354931
-3      -0,3390589585259363
-2      -0,5767248077568732
-1      -0,4400505857449335
0      0
1      0,4400505857449335
2      0,5767248077568732
3      0,3390589585259363
4      -0,06604332802354931
5      -0,3275791375914654
6      -0,2766838581275657
7      -0,004682823482345822
8      0,23463634685391466
9      0,2453117865733252
10      0,04347274616886141
11      -0,17678529895672163
12      -0,22344710449062752
13      -0,07031805212177818
14      0,1333751546987934*/
    }
}