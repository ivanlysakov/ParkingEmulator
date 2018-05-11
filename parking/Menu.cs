using System;
using System.Collections.Generic;
using System.Text;

namespace parking
{
    class Menu
    {
        public void mainMenu(Parking beePark)
        {
            bool repeat = false;
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Вітаємо вас на нашій парковці BeeParking!");
                Console.WriteLine("Чого бажаєте? Натисніть, будь ласка, відповідну клавішу");
                Console.WriteLine("===================================");
                Console.WriteLine("1.   Припаркувати авто.");
                Console.WriteLine("2.   Забрати авто з парковки.");
                Console.WriteLine("3.   Списати кошти (примусово)");
                Console.WriteLine("4.   Превірити баланс Вашого авто");
                Console.WriteLine("Esc  Вихід");
                Console.WriteLine("===================================");
                ConsoleKeyInfo keyPressed;
                keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Який тип Вашого авто?");
                            Console.WriteLine("1. Passanger");
                            Console.WriteLine("2. Truck");
                            Console.WriteLine("3. Bus");
                            Console.WriteLine("4. Moto");

                            keyPressed = Console.ReadKey();
                            CarType cartype;

                            switch (keyPressed.Key)

                            {
                                case ConsoleKey.D1:
                                    cartype = new CarType() { BodyType = Settings.CarTypes.Passanger };
                                    break;
                                case ConsoleKey.D2:
                                    cartype = new CarType() { BodyType = Settings.CarTypes.Truck };
                                    break;
                                case ConsoleKey.D3:
                                    cartype = new CarType() { BodyType = Settings.CarTypes.Bus };
                                    break;
                                case ConsoleKey.D4:
                                    cartype = new CarType() { BodyType = Settings.CarTypes.Moto };
                                    break;
                                default:
                                    Console.WriteLine("Такого типу авто не існує");
                                    return;

                            }

                            beePark.AddCar(cartype);

                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Припаркувати ще одне авто? - Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню? - Натисніть будь-яку клавішу");

                            keyPressed = Console.ReadKey();
                            if (keyPressed.Key == ConsoleKey.Enter)
                            {
                                repeat = true;
                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }
                        }
                        while (repeat == true);
                        Console.Clear();
                        this.mainMenu(beePark);
                        break;
                    case ConsoleKey.D2:
                        beePark.RemoveCar();
                        break;
                    case ConsoleKey.D3:
                        beePark.DoTransaction();

                        break;
                    case ConsoleKey.D4:

                        do
                        {
                            beePark.ShowCarBalance();
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Перевірити баланс іншого авто? - Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню? - Натисніть будь-яку клавішу");

                            keyPressed = Console.ReadKey();
                            if (keyPressed.Key == ConsoleKey.Enter)
                            {
                                repeat = true;
                                Console.Clear();
                            }
                            else
                            {
                                repeat = false;
                            }
                        }
                        while (repeat == true);
                        Console.Clear();
                        this.mainMenu(beePark);


                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Have a nice day)");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Oooops!! Зробіть Ваш вибір");
                        continue;
                }
            }

            while (!exit);
        }
    }
}
