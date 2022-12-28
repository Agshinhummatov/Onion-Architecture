using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetCustomerAverageByAges()
        {
            var customers = GetAll();

            int count = 0;

            foreach (var item in customers)
            {
                if (item.Age > 25 && item.Age < 30)
                {

                    count++;

                }

            }


            return count;
        }



        public double GetCustomerCountByFiltered()
        {
            var customers = GetAll();

            double avarage = 0;
            double sumAge = 0;

            foreach (var item in customers)
            {
                sumAge += item.Age;

            }

            //avarage = sumAge / customers.Length;

            return sumAge / customers.Length;
        }

        public Customer[] GetCustomersByFiltered(int startAge, int endAge)
        {
            var customers = GetAll();

            Customer[] result = new Customer[customers.Length];

            int count = 0;


            foreach (var item in customers)
            {
                if (item.Age> startAge && item.Age < endAge)
                {
                    result[count] = item;

                    count++;
                }


            }

            return result;

        }

        private Customer[] GetAll()
            {


                Customer c1 = new Customer
                {

                    Id = 1,
                    Name = "Shaiq",
                    Surname = "Kazimov",
                    Age = 25,
                    Postion = "Backend developer"
                };

                Customer c2 = new Customer
                {

                    Id = 2,
                    Name = "Pervin",
                    Surname = "Rahimli",
                    Age = 25,
                    Postion = "Frontend developer"
                };



                Customer c3 = new Customer
                {

                    Id = 3,
                    Name = "Aqsin",
                    Surname = "Hummatov",
                    Age = 27,
                    Postion = "Fullstack developer"
                };



                Customer c4 = new Customer
                {

                    Id = 4,
                    Name = "Jale",
                    Surname = "Abdullayeva",
                    Age = 18,
                    Postion = "Software instructor"
                };


                Customer[] customers = { c1, c2, c3, c4 };

                return customers;



            }










    }
 
        

}
