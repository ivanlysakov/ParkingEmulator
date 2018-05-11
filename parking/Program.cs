using System;

namespace parking
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //создаем меню
            Menu menu = new Menu();
            menu.mainMenu(Parking.Instance);
            Console.ReadKey();
        }
    }
}
