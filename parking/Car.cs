using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace parking
{
    class Car
    {
        public int ID { set; get; } //Свойство идентификатор
        public double Balance { set; get; }//Свойство баланс
        public CarType TypeofCar { set; get; } //Свойство тип машины

        public static int globalCarID;

       
        public Car (double balance, CarType type)

        {
            this.ID = Interlocked.Increment(ref globalCarID);
            this.Balance = balance;
            this.TypeofCar = type;
         

        }
    }
}
