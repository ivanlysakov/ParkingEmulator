using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace parking
{
    class Car
    {
        public Guid ID { set; get; } //Свойство идентификатор
        public double Balance { set; get; }//Свойство баланс
        public CarType TypeofCar { set; get; } //Свойство тип машины
        public static object CarTypes { get; internal set; }
        public enum CarType { Undefined, Passanger, Bus, Truck, Moto}

        public Car (double balance, CarType type)
        { 
            this.ID = Guid.NewGuid();
            this.Balance = balance;
            this.TypeofCar = type;
        }
    }
}
