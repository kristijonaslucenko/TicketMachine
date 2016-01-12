using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    class CardPayment : Paymentable
    {
        private string _id;

        public CardPayment (string id)
        {
            _id = id;
        }

        public bool Pay(int suma)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Cancel()
        {
            //throw new NotImplementedException();
        }
    }
}
