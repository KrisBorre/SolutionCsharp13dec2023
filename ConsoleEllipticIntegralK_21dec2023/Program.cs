using LibraryEllipticIntegrals20dec2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Legendre Elliptic Integral First Kind");

        double phi, alpha, val;

        Console.WriteLine("phi                       sin(alpha)               actual       ellf(phi,ak)");

        phi = 5.0; alpha = 2.0; val = 0.08726660;
        WriteRow(phi, alpha, val);

        phi = 5.0; alpha = 30.0; val = 0.08729413;
        WriteRow(phi, alpha, val);

        phi = 5.0; alpha = 88.0; val = 0.08737730;
        WriteRow(phi, alpha, val);

        phi = 30.0; alpha = 2.0; val = 0.52362636;
        WriteRow(phi, alpha, val);

        phi = 30.0; alpha = 30.0; val = 0.52942863;
        WriteRow(phi, alpha, val);

        phi = 30.0; alpha = 88.0; val = 0.54927042;
        WriteRow(phi, alpha, val);

        phi = 90.0; alpha = 2.0; val = 1.57127495;
        WriteRow(phi, alpha, val);

        phi = 90.0; alpha = 30.0; val = 1.68575035;
        WriteRow(phi, alpha, val);

        phi = 90.0; alpha = 88.0; val = 4.74271727;
        WriteRow(phi, alpha, val);

    }

    private static void WriteRow(double phi, double alpha, double val)
    {
        const double FAC = 3.141592653589793238 / 180.0;
        alpha = alpha * FAC;
        double ak = Math.Sin(alpha);
        phi = phi * FAC;
        EllipticIntegralCalculator20dec2023 calculator = new EllipticIntegralCalculator20dec2023();
        Console.WriteLine($"{phi}     {ak}     {val}     {calculator.ellf(phi, ak)}");
    }

    /*
     Legendre Elliptic Integral First Kind
phi                       sin(alpha)               actual       ellf(phi,ak)
0,08726646259971647     0,03489949670250097     0,0872666     0,08726659730031015
0,08726646259971647     0,49999999999999994     0,08729413     0,08729413462445562
0,08726646259971647     0,9993908270190958     0,0873773     0,08737730033499679
0,5235987755982988     0,03489949670250097     0,52362636     0,5236263623314071
0,5235987755982988     0,49999999999999994     0,52942863     0,5294286270519057
0,5235987755982988     0,9993908270190958     0,54927042     0,5492704152134483
1,5707963267948966     0,03489949670250097     1,57127495     1,571274952372225
1,5707963267948966     0,49999999999999994     1,68575035     1,6857503548125956
1,5707963267948966     0,9993908270190958     4,74271727     4,742717265278912
    */
}