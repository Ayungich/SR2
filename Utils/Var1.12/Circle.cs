namespace Utils.Var1._12
{
    public class Circle : _2DShape
    {
        double _radius;
        public double Radius
        {
            get { return _radius; }
            private set { _radius = value > 0 ? value : throw new ArgumentNullException("Радиус должен быть больше 0."); }
        }

        public Circle()
        {
            Random random = new Random();
            Radius = random.NextDouble() * 40 + 10; // Генерация случайного значения от 10 до 50
        }

        public override double CalculateArea() => Math.PI * Radius * Radius;

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override string ToString() =>  "Circle: " +
                                             $"Radius={Radius:f4}; " +
                                             $"Area={CalculateArea():f4}; " +
                                             $"Circumference={CalculatePerimeter():f4}";
    }
}
