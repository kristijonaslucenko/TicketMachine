using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    class TicketMachine : Controlable
    {
        private int _amount = 0;
        private Display display;
        private Paymentable paymentContext;

        public TicketMachine()
        {
            display = new Display();
        }

        public void DKK1()
        {
            _amount++;
            display.ShowEstimatedExpireTime(_amount);
        }

        public void DKK5()
        {
            _amount += 5;
            display.ShowEstimatedExpireTime(_amount);
        }

        public void DKK20()
        {
            _amount += 20;
            display.ShowEstimatedExpireTime(_amount);
        }

        public void OK()
        {
            if (true == paymentContext.Pay(_amount))
            {
                display.ShowText("Apmokėta!");
            }
            else
            {
                display.ShowText("Neapmokėta!");
            }

            _amount = 0;
        }

        public void Cancel()
        {
            paymentContext.Cancel();
            display.ShowText("Grąžinti pinigus!");
        }

        public void PutCreditCard(string id)
        {
            if (id.Count() < 5)
            {
                display.ShowText("Kortelė nevalidi!");
            }

            paymentContext = new CardPayment(id);
        }

        public void PutCoin(int amount)
        {
            if (amount != 1 && 
                amount != 2 && 
                amount != 5 && 
                amount != 10 && 
                amount != 20)
            {
                display.ShowText("Netinkama moneta.");
            }

            if (paymentContext == null ||
                paymentContext is CardPayment)
            {
                paymentContext = new CashPayment();
            }

            _amount += amount;
            display.ShowEstimatedExpireTime(_amount);
        }
    }
}
