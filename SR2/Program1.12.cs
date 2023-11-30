//using Utils;
//using Utils.Var1._12;

//namespace SR2
//{
//    class Program
//    {
//        static void Main()
//        {
//            do
//            {
//                Console.Clear();
//                Console.ForegroundColor = ConsoleColor.DarkMagenta;

//                Assistance.SlowColorWriteLine("Нажмите Enter для продолжения или Escape для выхода...\n", ConsoleColor.DarkMagenta);
//                ConsoleKey exitKey = Console.ReadKey(true).Key;

//                if (exitKey == ConsoleKey.Escape)
//                {
//                    Assistance.SlowColorWriteLine("Exiting...", ConsoleColor.DarkCyan);
//                    Thread.Sleep(200);
//                    Environment.Exit(0);
//                }

//                else if (exitKey == ConsoleKey.Enter)
//                {
//                    Console.Clear();
//                    int n = DataCheckers.IntegerCheck("Введите количество объектов Square (0 < n < 10):\n-> ", ConsoleColor.Magenta);
//                    int m = DataCheckers.IntegerCheck("Введите количество объектов Circle (0 < m < 10):\n-> ", ConsoleColor.Magenta);

//                    try
//                    {
//                        _2DShape[] shapes = new _2DShape[m + n];

//                        for (int i = 0; i < n; i++)
//                        {
//                            shapes[i] = new Square();
//                        }

//                        for (int i = m; i < n + m; i++)
//                        {
//                            shapes[i] = new Circle();
//                        }

//                        foreach (object shape in shapes)
//                        {
//                            Console.WriteLine($"\n{shape.ToString()}");
//                        }
//                    }
//                    catch (NullReferenceException ex)
//                    {
//                        Assistance.SlowColorWriteLine($"\n{ex.Message}", ConsoleColor.Red);
//                    }
//                    catch (Exception ex)
//                    {
//                        Assistance.SlowColorWriteLine($"\n{ex.Message}", ConsoleColor.Red);
//                    }
//                }

//                Assistance.SlowColorWriteLine("\nНажмите Enter для продолжения или \'Escape\' для выхода...", ConsoleColor.Magenta);

//            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
//        }
//    }
//}
