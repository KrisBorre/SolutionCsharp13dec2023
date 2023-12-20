namespace LibraryBesselFunction13dec2023
{
    public class BesselFunctionJ0_13dec2023 : FunctionAbstractClass13dec2023
    {
        BesselCalculator13dec2023 bessjy;

        public BesselFunctionJ0_13dec2023()
        {
             this.bessjy = new BesselCalculator13dec2023();
        }

        public override double Function(double x)
        {          
            return this.bessjy.j0(x);
        }

        public double Derivative(double x)
        {
            return - this.bessjy.j1(x);
        }
    }
}