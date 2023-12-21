using LibraryEllipticIntegrals20dec2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Legendre Elliptic Integral Second Kind");

        double phi, alpha, val;

        Console.WriteLine("phi                       sin(alpha)               actual       ellf(phi,ak)");

        phi = 5.0; alpha = 2.0; val = 0.08726633;
        WriteRow(phi, alpha, val);

        phi = 5.0; alpha = 30.0; val = 0.08723881;
        WriteRow(phi, alpha, val);

        phi = 5.0; alpha = 88.0; val = 0.08715588;
        WriteRow(phi, alpha, val);

        phi = 30.0; alpha = 2.0; val = 0.52357119;
        WriteRow(phi, alpha, val);

        phi = 30.0; alpha = 30.0; val = 0.51788193;
        WriteRow(phi, alpha, val);

        phi = 30.0; alpha = 88.0; val = 0.50003003;
        WriteRow(phi, alpha, val);

        phi = 90.0; alpha = 2.0; val = 1.57031792;
        WriteRow(phi, alpha, val);

        phi = 90.0; alpha = 30.0; val = 1.46746221;
        WriteRow(phi, alpha, val);

        phi = 90.0; alpha = 88.0; val = 1.00258409;
        WriteRow(phi, alpha, val);

    }

    private static void WriteRow(double phi, double alpha, double val)
    {
        const double FAC = 3.141592653589793238 / 180.0;
        alpha = alpha * FAC;
        double ak = Math.Sin(alpha);
        phi = phi * FAC;
        EllipticIntegralCalculator20dec2023 calculator = new EllipticIntegralCalculator20dec2023();
        Console.WriteLine($"{phi}     {ak}     {val}     {calculator.elle(phi, ak)}");
    }

    /*
     Legendre Elliptic Integral Second Kind
phi                       sin(alpha)               actual       ellf(phi,ak)
0,08726646259971647     0,03489949670250097     0,08726633     0,08726632789949684
0,08726646259971647     0,49999999999999994     0,08723881     0,08723880635477968
0,08726646259971647     0,9993908270190958     0,08715588     0,08715587775585158
0,5235987755982988     0,03489949670250097     0,52357119     0,5235711914271307
0,5235987755982988     0,49999999999999994     0,51788193     0,5178819348599379
0,5235987755982988     0,9993908270190958     0,50003003     0,5000300250843459
1,5707963267948966     0,03489949670250097     1,57031792     1,570317919897448
1,5707963267948966     0,49999999999999994     1,46746221     1,4674622093394267
1,5707963267948966     0,9993908270190958     1,00258409     1,0025840855275514
    */
}

