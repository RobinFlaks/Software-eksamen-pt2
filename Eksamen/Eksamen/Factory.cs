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
        //to add more stores: add names under "InnNames" and change the number in Bazzar -> SetFinisheds if statement
        //to add more Customers: add names under "CustomerNames"
        {
            Store.CreateStore();
            Store.CreateStore();
            CustomerGenerator Customer = new CustomerGenerator();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
            Customer.CreateCustomer();
        }
    }
}
