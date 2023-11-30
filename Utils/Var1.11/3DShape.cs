namespace Utils
{
    public abstract class _3DShape
    {
        protected double _size;

        public double Size
        {
            get { return _size; }
            set { _size = value > 0 ? value : throw new ArgumentNullException("Сторона должна быть больше 0."); }
        }

        protected _3DShape()
        {
            Random random = new();
            Size = random.NextDouble() * 99 + 1; // Генерируем случайное число от 1 до 100
        }

        public abstract double CalculateSurfaceArea();
        public abstract double CalculateVolume();
        public override string ToString() => $"Size={Size:F2}";
    }
}


