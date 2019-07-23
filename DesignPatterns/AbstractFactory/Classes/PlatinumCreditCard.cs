using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    public class PlatinumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 100;
        }

        public int GetAnnualCharge()
        {
            return 100;
        }
    }
}
