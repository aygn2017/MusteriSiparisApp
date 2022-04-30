using CustomerOrderTracking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderTracking.Core
{
    public interface ICustomerRepository:IRepository<Customer>
    {
    }
}
