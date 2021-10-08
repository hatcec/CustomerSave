using Interfaces.Abstract;
using Interfaces.Adapters;
using Interfaces.Concrete;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbacksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995,3,12), FirstName = "x", LastName = "x", NationalityId = "xxxxxxxxxxx" });
            Console.ReadLine();
        }
    }
}
