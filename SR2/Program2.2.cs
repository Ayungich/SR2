using Utils.Var2._2;
using Utils;

namespace SR2
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Assistance.SlowColorWriteLine("Нажмите Enter для продолжения или Escape для выхода...\n", ConsoleColor.DarkMagenta);
                ConsoleKey exitKey = Console.ReadKey(true).Key;

                if (exitKey == ConsoleKey.Escape)
                {
                    Assistance.SlowColorWriteLine("Exiting...", ConsoleColor.DarkCyan);
                    Thread.Sleep(200);
                    Environment.Exit(0);
                }

                else if (exitKey == ConsoleKey.Enter)
                {
                    Console.Clear();
                    List<Dish> dishesData = new();
                    Assistance.SlowColorWriteLine("Для выхода введите значение 0 в стоимость обоих блюд\n", ConsoleColor.DarkMagenta);
                    Assistance.SlowColorWriteLine("Выберите cтоимость блюда (1 - Закуска, " +
                                                                      "2 - Основное блюдо, " +
                                                                      "3 - Десерт): " +
                                                                      "4 - Выход из программы):\n-> ", ConsoleColor.Magenta);
                    try
                    {
                        double saladPrice;
                        double soupPrice;
                        do
                        {
                            saladPrice = DataCheckers.DoubleCheck("Введите цену салата:\n-> ", ConsoleColor.Magenta);
                            soupPrice = DataCheckers.DoubleCheck("Введите цену супа:\n-> ", ConsoleColor.Magenta);
                            dishesData.Add(CreatingDish.CreateAppetizer(saladPrice, soupPrice));
                        } while (saladPrice != 0 || soupPrice != 0);

                        double pastaPrice;
                        double steakPrice;
                        do
                        {
                            pastaPrice = DataCheckers.DoubleCheck("Введите цену макарон:\n-> ", ConsoleColor.Magenta);
                            steakPrice = DataCheckers.DoubleCheck("Введите цену отбивной:\n-> ", ConsoleColor.Magenta);
                            dishesData.Add(CreatingDish.CreateMainCourse(pastaPrice, steakPrice));
                        } while (pastaPrice != 0 || steakPrice != 0);

                        double cakePrice;
                        double iceCreamPrice;
                        do
                        {
                            cakePrice = DataCheckers.DoubleCheck("Введите цену торта:\n-> ", ConsoleColor.Magenta);
                            iceCreamPrice = DataCheckers.DoubleCheck("Введите цену мороженного:\n-> ", ConsoleColor.Magenta);
                            dishesData.Add(CreatingDish.CreateDessert(cakePrice, iceCreamPrice));
                        } while (cakePrice != 0 || iceCreamPrice != 0);


                        double totalPrice = 0;
                        foreach (var dish in dishesData)
                        {
                            Console.WriteLine(dish.ToString());
                            totalPrice += dish.CalculatePrice();
                        }

                        Console.WriteLine($"Общая стоимость: {totalPrice:f2}");
                    }
                    catch (NullReferenceException ex)
                    {
                        Assistance.SlowColorWriteLine($"\n{ex.Message}", ConsoleColor.Red);
                    }
                    catch (ArgumentException ex)
                    {
                        Assistance.SlowColorWriteLine($"\n{ex.Message}", ConsoleColor.Red);
                    }
                    catch (Exception ex)
                    {
                        Assistance.SlowColorWriteLine($"\n{ex.Message}", ConsoleColor.Red);
                    }
                }

                Assistance.SlowColorWriteLine("\nНажмите Enter для продолжения или \'Escape\' для выхода...", ConsoleColor.Magenta);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

