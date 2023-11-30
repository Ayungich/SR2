namespace Utils.Var2._2
{
    public class MainCourse : Dish
    {
        double _pastaPrice;
        double _steakPrice;
        public double PastaPrice
        {
            get { return _pastaPrice; }
            set { _pastaPrice = value >= 0 ? value : throw new ArgumentOutOfRangeException("Цена должна быть больше 0."); }
        }
        public double SteakPrice
        {
            get { return _steakPrice; }
            set { _steakPrice = value >= 0 ? value : throw new ArgumentOutOfRangeException("Цена должна быть больше 0."); }
        }

        public MainCourse(double pastaPrice, double steakPrice)
        {
            PastaPrice = pastaPrice;
            SteakPrice = steakPrice;
        }

        public override double CalculatePrice()
        {
            double total = PastaPrice + SteakPrice;
            return total + total * 0.1; // Добавляем 10% сервисный сбор
        }

        public override string ToString() => $"Main Course: Pasta={PastaPrice:F2}, Steak={SteakPrice:F2}, {base.ToString()}";
    }
}
