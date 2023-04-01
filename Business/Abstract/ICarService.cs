using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        public List<CarDetailDto> GetCarDetails();
        List<Car> GetByUnitPrice(decimal min, decimal max);
        void Add(Car car);
        List<Car> GetCarsByBrandId(int brandid);
        List<Car> GetCarsByColorId(int colorid);
    }
}
