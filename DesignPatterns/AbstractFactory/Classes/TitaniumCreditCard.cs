using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    public class TitaniumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium CreditCard";
        }

        public int GetCreditLimit()
        {
            return 10;
        }

        public int GetAnnualCharge()
        {
            return 10;
        }
    }
}
