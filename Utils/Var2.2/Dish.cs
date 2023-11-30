namespace Utils.Var2._2
{
    public abstract class Dish
    {
        public abstract double CalculatePrice();
        public override string ToString() => $"Price: {CalculatePrice():F2}";
    }
}
