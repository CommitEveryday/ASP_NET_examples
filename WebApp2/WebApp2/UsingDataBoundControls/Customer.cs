using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.UsingDataBoundControls
{
    public class Customer
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Phone { get; set; }

        public Customer()
        { }

        public Customer(Int32 Id, String Name, String City, String State, String Phone)
        {
            this.Id = Id;
            this.Name = Name;
            this.City = City;
            this.State = State;
            this.Phone = Phone;
        }
    }
}