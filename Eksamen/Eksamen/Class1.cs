using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{
    public class Factory
    {
        public void StartProducing()
        {
            Store.CreateStore();
            CustomerGenerator Customer = new CustomerGenerator();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
        }
    }
}
