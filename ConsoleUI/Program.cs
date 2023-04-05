using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarTest();

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
                var result = carManager.GetCarsByBrandId(11);
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
