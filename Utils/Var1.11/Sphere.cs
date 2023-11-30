namespace Utils
{
    public class Sphere : _3DShape
    {
        public Sphere() : base() { }

        public override double CalculateSurfaceArea() => 4 * Math.PI * Size * Size;


        public override double CalculateVolume() => (4.0 / 3) * Math.PI * Math.Pow(Size, 3);

        public override string ToString() => $"Sphere: {base.ToString()}; " +
                                             $"SurfaceArea={CalculateSurfaceArea():F2}; " +
                                             $"Volume={CalculateVolume():F2}";
    }
}
