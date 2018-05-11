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
                Console.WriteLine("========================================================");
                Console.WriteLine("1.   Припаркувати авто.");
                Console.WriteLine("2.   Поповнити баланс авто.");
                Console.WriteLine("3.   Забрати авто з парковки.");
                Console.WriteLine("4.   Превірити баланс Вашого авто");
                Console.WriteLine("5.   Вивести загальньний дохід парковки.");
                Console.WriteLine("6.   Вивести кількість вільних місць на парковці.");
                Console.WriteLine("7.   Вивести історію транзакцій за останню хвилину.");
                Console.WriteLine("8.   Вивести Transactions.log");
                Console.WriteLine("========================================================");
                Console.WriteLine("Esc  Вихід");
                ConsoleKeyInfo keyPressed;
                keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                     
                        do
                            {
                                bool done = false;
                                CarType cartype = null;
                                do
                                {


                                if (beePark.ParkingSpace >= 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("==========================");
                                    Console.WriteLine("Який тип Вашого авто?");
                                    Console.WriteLine("==========================");
                                    Console.WriteLine("1. Passanger");
                                    Console.WriteLine("2. Truck");
                                    Console.WriteLine("3. Bus");
                                    Console.WriteLine("4. Moto");
                                    Console.WriteLine("==========================");
                                    Console.WriteLine("Esc. Повернутися в головне меню");
                                    keyPressed = Console.ReadKey();
                                    switch (keyPressed.Key)

                                    {
                                        case ConsoleKey.D1:
                                            cartype = new CarType() { BodyType = Settings.CarTypes.Passanger };
                                            done = true;
                                            break;
                                        case ConsoleKey.D2:
                                            cartype = new CarType() { BodyType = Settings.CarTypes.Truck };
                                            done = true;
                                            break;
                                        case ConsoleKey.D3:
                                            cartype = new CarType() { BodyType = Settings.CarTypes.Bus };
                                            done = true;
                                            break;
                                        case ConsoleKey.D4:
                                            cartype = new CarType() { BodyType = Settings.CarTypes.Moto };
                                            done = true;
                                            break;
                                        case ConsoleKey.Escape:
                                            done = true;
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("На жаль, такого типу авто не існує");
                                            Console.WriteLine("Натисніть будь-яку клавішу");
                                            Console.ReadKey();
                                            continue;

                                    }
                                }
                                else
                                {
                                    done = true;
                                    Console.Clear();
                                    Console.WriteLine("На разі всі місця зайняті! Зверніться пізніше!");
                                    Console.WriteLine("Для повернення в основне меню натисніть будь-яку клавішу");
                                    Console.ReadKey();
                                }
                            }
                                while (!done);

                                if (cartype != null)
                                    beePark.AddCar(cartype);
                                else
                                {
                                    Console.Clear();
                                    this.mainMenu(beePark);
                                }

                                Console.Clear();
                                Console.WriteLine("==============================================================");
                                Console.WriteLine("Ваше авто успішно припарковано!");
                                Console.WriteLine("==============================================================");
                                Console.WriteLine("Припаркувати ще одне авто?  ---  Натисніть Enter.");
                                Console.WriteLine("Повернутися в головне меню? ---  Натисніть будь-яку клавішу");
                                Console.WriteLine("==============================================================");
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
                        
                        break;
                    case ConsoleKey.D2:

                        do
                        {
                            beePark.RefillCarBalance();

                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Поповнити баланс іншого авто? ---   Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню?    ---   Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");

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
                      
                        break;

                        case ConsoleKey.D3:
                        
                        do
                        {
                            beePark.RemoveCar();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Ви забрали своє авто з парковки!");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Забрати інше авто з парковки? ---  Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню?   ---  Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");

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
                        
                        break;

                    case ConsoleKey.D4:

                        do
                        {
                            beePark.ShowCarBalance();
                            
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Перевірити баланс іншого авто? ---   Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню?    ---   Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");

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
                        
                        break;

                    case ConsoleKey.D5:

                        do
                        {
                            beePark.ShowParkingBalance();
                          
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Перевірити баланс ще раз?   --- Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню? --- Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");

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
                        
                        break;
                    case ConsoleKey.D6:

                        do
                        {
                            beePark.ShowParkingSpace();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Перевірити кількість місць ще раз? - Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню? - Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");

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
                        
                        break;
                    case ConsoleKey.D7:

                        do
                        {
                            beePark.TransactionLastMinute();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Перевірити баланс іншого авто? - Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню? - Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");

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
                       
                        break;

                  
                    case ConsoleKey.D8:

                        do
                        {
                            beePark.ReadTransactionLog();
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("Бажаєте спробувати ще раз?");
                            Console.WriteLine("Вивести лог ще раз? - Натисніть Enter.");
                            Console.WriteLine("Повернутися в головне меню? - Натисніть будь-яку клавішу");
                            Console.WriteLine("==============================================================");
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
                        
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Have a nice day)");
                        exit = true;
                        return;
                        
                    default:
                        Console.WriteLine("Oooops!! Зробіть Ваш вибір");
                        continue;
                }
            }

            while (!exit);
        }
    }
}
