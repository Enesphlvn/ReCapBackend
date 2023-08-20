using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 250, ModelYear = "2013", Description = "Honda Benzinli manuel araç"},
                new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 450, ModelYear = "2019", Description = "BMW Benzinli otomatik araç"},
                new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 500, ModelYear = "2022", Description = "Mercedes Benzinli otomatik ve turbolu araç"},
                new Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 150, ModelYear = "2010", Description = "Dacia Dizel manuel araç"},
                new Car { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 300, ModelYear = "2016", Description = "Opel Dizel otomatik araç"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
