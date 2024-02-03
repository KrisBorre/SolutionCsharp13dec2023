using LibraryBesselFunction13dec2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Bessel functions!");

        BesselFunctionJ0_13dec2023 j0 = new BesselFunctionJ0_13dec2023();
        double x;

        Console.WriteLine($"{nameof(x)}        {nameof(j0)}({nameof(x)})");
        //Console.WriteLine("x        j0(x)");
        for (int i = -5; i <= 14; i++)
        {
            x = (double)i;
            Console.WriteLine($"{i}      {j0.Function(x)}");
        }

        Console.ReadLine();

        /*Hello Bessel functions!
x        j0(x)
-5      -0,1775967713143385
-4      -0,39714980986384724
-3      -0,26005195490193356
-2      0,22389077914123565
-1      0,765197686557967
0      0,9999999999999998
1      0,765197686557967
2      0,22389077914123565
3      -0,26005195490193356
4      -0,39714980986384724
5      -0,1775967713143385
6      0,1506452572509968
7      0,30007927051955546
8      0,17165080713755396
9      -0,0903336111828759
10      -0,2459357644513483
11      -0,17119030040719624
12      0,04768931079683335
13      0,2069261023770677
14      0,17107347611045876*/
    }
}