using Interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Concrete
{
    public class CutomerCheckManager : ICustomerCheckService
    {

        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
