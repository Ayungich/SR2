namespace Utils.Var2._2
{
    public class Dessert : Dish
    {
        double _cakePrice;
        double _iceCreamPrice;
        public double CakePrice
        {
            get { return _cakePrice; }
            set { _cakePrice = value >= 0 ? value : throw new ArgumentOutOfRangeException("Цена должна быть больше 0."); }
        }
        public double IceCreamPrice
        {
            get { return _iceCreamPrice; }
            set { _iceCreamPrice = value >= 0 ? value : throw new ArgumentOutOfRangeException("Цена должна быть больше 0."); }
        }

        public Dessert(double cakePrice, double iceCreamPrice)
        {
            CakePrice = cakePrice;
            IceCreamPrice = iceCreamPrice;
        }

        public override double CalculatePrice() => CakePrice + IceCreamPrice;
        public override string ToString() => $"Dessert: Cake={CakePrice:F2}, Ice Cream={IceCreamPrice:F2}, {base.ToString()}";
    }
}
