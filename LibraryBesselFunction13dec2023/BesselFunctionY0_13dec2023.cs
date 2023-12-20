namespace LibraryBesselFunction13dec2023
{
    public class BesselFunctionY0_13dec2023 : FunctionAbstractClass13dec2023
    {
        public override double Function(double x)
        {
            var bessjy = new BesselCalculator13dec2023();
            return bessjy.y0(x);
        }
    }
}
