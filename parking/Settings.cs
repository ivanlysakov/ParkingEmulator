using System;
using System.Collections.Generic;
using System.Text;

namespace parking
{
    static class Settings
    {
        //Свойство Timeout (каждые N-секунд списывает средства за парковочное место) - по умолчанию 3 секунды
        public static int Timeout { get; } = 3;
       
        //Dictionary - словарь для хранения цен за парковку
        public static Dictionary<Car.CarType, int> Tarif { get; } = new Dictionary<Car.CarType, int>
            {
               { Car.CarType.Truck ,       5 } ,
               { Car.CarType.Passanger ,   3 },
               { Car.CarType.Bus ,         2 },
               { Car.CarType.Moto ,        1 }
            };
        //Свойство ParkingSpace - вместимость парковки(общее кол-во мест)
        public static int ParkingSpace { get; } = 5;
        
        //Свойство Fine - коэффициент штрафа
        public static int Fine { get; } = 2; 
       

    }

}
