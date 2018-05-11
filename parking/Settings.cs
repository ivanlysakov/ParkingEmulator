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
        public static Dictionary<CarTypes, int> Tarif { get; } = new Dictionary<CarTypes, int>
            {
               { CarTypes.Truck ,       5 } ,
               { CarTypes.Passanger ,   3 },
               { CarTypes.Bus ,         2 },
               { CarTypes.Moto ,        1 }
            };
        //Свойство ParkingSpace - вместимость парковки(общее кол-во мест)
        public static int ParkingSpace { get; } = 5;
        
        //Свойство Fine - коэффициент штрафа
        public static int Fine { get; } = 2; 
        //виды авто
        public enum CarTypes { Passanger, Truck, Bus, Moto }

    }

}
