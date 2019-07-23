using System;
using Factory.Classes;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardType = 2;
            //Getting the instance from the factory class

            ICreditCard cardDetails = CardFactory.GetCardInstance(cardType);
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
