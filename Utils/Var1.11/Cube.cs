namespace Utils
{
    public class Cube : _3DShape
    {
        public Cube() : base() { }

        public override double CalculateSurfaceArea() => 6 * Size * Size;
        public override double CalculateVolume() => Math.Pow(Size, 3);
        public override string ToString() => $"Cube: {base.ToString()}; " +
                                             $"SurfaceArea={CalculateSurfaceArea():F2}; " +
                                             $"Volume={CalculateVolume():F2}";
    }
}
