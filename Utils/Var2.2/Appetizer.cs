namespace Utils.Var2._2
{
    public class Appetizer : Dish
    {
        double _saladPrice;
        double _soupPrice;
        public double SaladPrice
        {
            get { return _saladPrice; }
            set { _saladPrice = value >= 0 ? value : throw new ArgumentOutOfRangeException("Цена должна быть больше 0."); }
        }
        public double SoupPrice
        {
            get { return _soupPrice; }
            set { _soupPrice = value >= 0 ? value : throw new ArgumentOutOfRangeException("Цена должна быть больше 0."); }
        }

        public Appetizer(double saladPrice, double soupPrice)
        {
            SaladPrice = saladPrice;
            SoupPrice = soupPrice;
        }

        public override double CalculatePrice() => SaladPrice + SoupPrice;
        public override string ToString() => $"Appetizer: Salad={SaladPrice:F2}, Soup={SoupPrice:F2}, {base.ToString()}";
    }
}
