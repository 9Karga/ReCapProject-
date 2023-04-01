using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }

            else
            {
                Console.WriteLine("Hatalı bilgi girişi yaptınız, Lütfen isim veya kiralama ücretini kontrol ediniz.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=> c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetAll(c => c.BrandId == brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(c => c.ColorId == colorid);
        }
    }
}
