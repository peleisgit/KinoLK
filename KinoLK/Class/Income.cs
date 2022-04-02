using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLK.Class
{
    class Income
    {
        private decimal income;
        private int numberTicketsSold;
        private int numberTransaction;
        private int numberPopcorns;
        private int numberDrinks;

        public Income()
        {
            
        }


        public Income(decimal income, int numberTicketsSold, int numberTransaction, int numberPopcorns, int numberDrinks)
        {
            this.income = income;
            this.numberTicketsSold = numberTicketsSold;
            this.numberTransaction = numberTransaction;
            this.numberPopcorns = numberPopcorns;
            this.numberDrinks = numberDrinks;
        }

        public decimal GetIncome()
        {
            return income;
        }

        public decimal GetNumberTicketsSold()
        {
            return numberTicketsSold;
        }
        public decimal GetNumberTransaction()
        {
            return numberTransaction;
        }

        public decimal GetNumberPopcorns()
        {
            return numberPopcorns;
        }
        public decimal GetNumberDrinks()
        {
            return numberDrinks;
        }


    }
}
