using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

            //CarDetailTest();
            //UserTest();
            //CustomerTest();

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName + "/" + user.LastName);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.CarName);
                }
            }
        }



        private static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                var result = carManager.GetAll();
                if (result.Success==true)
                {
                    foreach (var car in result.Data)
                    {
                    Console.WriteLine(car.CarName);
                    }
                }
            }

        
    } 
}
