using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.UsingDataBoundControls
{
    public class CustomerList
    {
        private static List<Customer> custList = new List<Customer>();

        public List<Customer> Select()
        {
            return custList;
        }

        public void Update(Customer updateCustomer)
        {
            Customer customerFound = custList.FirstOrDefault<Customer>(c => c.Id == updateCustomer.Id);
            if (customerFound == null)
                return;
            customerFound.Name = updateCustomer.Name;
            customerFound.City = updateCustomer.City;
            customerFound.State = updateCustomer.State;
            customerFound.Phone = updateCustomer.Phone;
        }

        public void Insert(Customer customer)
        {
            custList.Add(customer);
        }

        public void Delete(Customer deleteCustomer)
        {
            custList.RemoveAll(c => c.Id == deleteCustomer.Id);
        }

        public Customer SelectSingle(Int32 id)
        {
            if (id == -1)
                return null;
            return custList.FirstOrDefault<Customer>(c => c.Id == id);
        }
    }
}