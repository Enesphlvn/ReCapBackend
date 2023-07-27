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
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice +"TL");
            }

            Console.Read();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}