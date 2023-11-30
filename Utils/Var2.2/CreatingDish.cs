namespace Utils.Var2._2
{
    public class CreatingDish
    {
        public static Dish CreateAppetizer(double firstPrice, double secondPrice)
        {
            double saladPrice = firstPrice;
            double soupPrice = secondPrice;

            return new Appetizer(saladPrice, soupPrice);
        }

        public static Dish CreateMainCourse(double firstPrice, double secondPrice)
        {
            double pastaPrice = firstPrice;
            double steakPrice = secondPrice;

            return new MainCourse(pastaPrice, steakPrice);
        }

        public static Dish CreateDessert(double firstPrice, double secondPrice)
        {
            double cakePrice = firstPrice;
            double iceCreamPrice = secondPrice;

            return new Dessert(cakePrice, iceCreamPrice);
        }
    }
}
