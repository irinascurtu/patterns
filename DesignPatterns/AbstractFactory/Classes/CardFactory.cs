using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    public class CardFactory
    {
        public static ICreditCard GetCardInstance(int cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType == 1)
            {
                cardDetails = new MoneyBackCreditCard();
            }
            else if (cardType == 2)
            {
                cardDetails = new TitaniumCreditCard();
            }
            else if (cardType == 3)
            {
                cardDetails = new PlatinumCreditCard();
            }
            return cardDetails;
        }
    }

   




  
}
