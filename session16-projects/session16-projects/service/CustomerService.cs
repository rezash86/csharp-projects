using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session16_projects.service
{
    class CustomerService
    {
        ZzaEntities ZzaEntities = new ZzaEntities();
        public List<Customer> GetCustomers()
        {
            using (var zzContext = new ZzaEntities())
            {
                var query = from customer in ZzaEntities.Customers
                                //where
                            select customer;

                return query.ToList<Customer>();
            }

        }


        public Guid AddCustomer(Customer customer)
        {
            using (var zzContext = new ZzaEntities())
            {
                //Customer customer = new Customer()
                //{
                //    Id = Guid.NewGuid(),
                //    FirstName = "Antinio",
                //    LastName = "Bandras",
                //    Phone = "11111111"
                //};

                zzContext.Customers.Add(customer);
                zzContext.SaveChanges();
            }

            var query = from cust in ZzaEntities.Customers
                        where cust.FirstName == customer.FirstName && cust.LastName == customer.LastName
                        select cust.Id;
            
            return query.FirstOrDefault();
        }

        public bool EditCustomer(Guid customerGuid, string newName)
        {
            using (var zzContext = new ZzaEntities())
            {

                var query = from customer in ZzaEntities.Customers
                            where customer.Id == customerGuid
                            select customer;

                Customer selectedOne = query.First();
                selectedOne.FirstName = newName;
               

                zzContext.SaveChanges();

            }
            return true;
        }

    }
}
