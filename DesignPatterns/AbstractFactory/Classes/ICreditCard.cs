using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
