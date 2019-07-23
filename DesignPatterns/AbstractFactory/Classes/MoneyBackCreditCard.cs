using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    public class MoneyBackCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 10;
        }

        public int GetAnnualCharge()
        {
            return 0;
        }
    }

}
