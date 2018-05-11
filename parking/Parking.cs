using System;
using System.Collections.Generic;
using System.Text;

namespace parking
{
    class Parking  //клас Парковка (патерн Singleton)
    {
        public List<Car> Cars { get; set; }//список машин
        public List<Transaction> Trans { get; private set; }//список транзакцій
        public int ParkingBalance { get; private set; }//баланс парковки
        public int Fine { get; private set; }//штраф
        public int TimeOut { get; }
        public Dictionary<Settings.CarTypes, int> Tarif { get; }
        public int ParkingSpace { get; set; }

        public enum CarTypes { };

        private static readonly Lazy<Parking> lazy = new Lazy<Parking>(() => new Parking());

        public static Parking Instance { get { return lazy.Value; } }

        private Parking()
        {
            this.Cars = new List<Car>();
            this.Trans = new List<Transaction>();
            this.TimeOut = Settings.Timeout;
            this.Tarif = Settings.Tarif;
            this.ParkingSpace = Settings.ParkingSpace;
            this.Fine = Settings.Fine;
            //запускаем списание средств каждые 3 минуты
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(TimeOut);

            var timer = new System.Threading.Timer((e) =>
            {
                DoTransaction();
            }, null, startTimeSpan, periodTimeSpan);

        }

        public void AddCar(CarType cartype)
        {
            Car car = new Car(15, cartype);
            Cars.Add(car);
            ParkingSpace--;


        }

        public void RemoveCar()

        {

            Console.Clear();
            Console.WriteLine("What ID of your car?");

            try
            {

                int userChoice = Int32.Parse(Console.ReadLine());
                Car removeCar = Cars.Find(x => x.ID == userChoice);
                Cars.Remove(removeCar);
                ParkingSpace++;
            }
            catch

            {

                Console.WriteLine("Такого авто немає в списку");

            }


        }

        public void DoTransaction()

        {
            if (Cars.Count > 0)

            {
                foreach (var car in Cars)
                {
                    int tarif = 0;
                    switch (car.TypeofCar.BodyType)
                    {
                        case Settings.CarTypes.Passanger:
                            tarif = Tarif[Settings.CarTypes.Passanger];
                            break;
                        case Settings.CarTypes.Bus:
                            tarif = Tarif[Settings.CarTypes.Bus];
                            break;
                        case Settings.CarTypes.Truck:
                            tarif = Tarif[Settings.CarTypes.Truck];
                            break;
                        case Settings.CarTypes.Moto:
                            tarif = Tarif[Settings.CarTypes.Moto];
                            break;

                        default:
                            break;
                    }

                    if (car.Balance < tarif)
                        tarif = tarif + (tarif * Fine);

                    car.Balance = car.Balance - tarif;
                    ParkingBalance = ParkingBalance + tarif;
                }

            }
        }
        
        public void ShowCarBalance()

        {

            Console.Clear();
            Console.WriteLine("Який номер вашого авто [1,2,3...]?");

            try
            {

                int userChoice = Int32.Parse(Console.ReadLine());
                Car _Car = Cars.Find(x => x.ID == userChoice);
                Console.Clear();
                Console.WriteLine("Баланс Вашого авто {0} грн. ", _Car.Balance.ToString());

            }
            catch

            {

                Console.WriteLine("На жаль, таке авто у нас не припарковане");

            }




        }
    }
}