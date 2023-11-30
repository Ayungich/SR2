namespace Utils.Var1._12
{
    public abstract class _2DShape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public override string ToString() => $"Area={CalculateArea():F4}, Perimeter={CalculatePerimeter():F4}";
    }
}
