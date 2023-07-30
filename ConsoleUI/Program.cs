using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(new Car { CarName = "asssssssssdas", ColorId = 2, BrandId = 5, DailyPrice = 300, ModelYear = "2020"});
            //efCarDal.Delete(new Car { Id = 8});
            //efCarDal.Update(new Car { Id= 7, BrandId = 3, ColorId = 5, CarName = "X7", Description = "Ultra lük bir araç", ModelYear = "2022", DailyPrice = 950});

            //CarTest();

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " - " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.Read();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}