using System;
using System.Collections.Generic;
using System.Text;

namespace parking
{
    class Transaction
    {
        //Свойство Дата/Время Транзакции
        public DateTime TimeOfTransaction { get; set; }
        //Свойство Идентификатор машины
        public int CarID { get; set; }
        //Свойство Списанные средства
        public double TransactionAmount { get; set; }

        public Transaction()
        {
        }

    public Transaction(DateTime time, int id, double amount)

        {
            this.TransactionAmount = amount;
            this.CarID = id;
            this.TimeOfTransaction = time; 
        }
    }
}
