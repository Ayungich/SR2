namespace Utils.Var1._12
{
    public class Square : _2DShape
    {
        double _side;
        public double Side
        {
            get { return _side; }
            private set { _side = value > 0 ? value : throw new ArgumentNullException("Сторона должна быть больше 0."); }
        }
        public Square()
        {
            Random random = new Random();
            Side = random.NextDouble() * 40 + 10; // Генерация случайного значения от 10 до 50
        }

        public override double CalculateArea() => Side * Side;
        public override double CalculatePerimeter() => 4 * Side;
        public override string ToString() =>  "Square: " +
                                             $"Side: {Side:f4}; " +
                                             $"Area={CalculateArea():f4}; " +
                                             $"Perimeter={CalculatePerimeter():f4}";
    }
}
