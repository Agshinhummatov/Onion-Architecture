using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerService
    {
        double GetCustomerCountByFiltered();


        Customer [] GetCustomersByFiltered(int startAge,int endAge);

        int  GetCustomerAverageByAges();


    }

    


}
