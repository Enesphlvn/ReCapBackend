﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarByBrandAndColor(int brandId, int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             where c.BrandId == brandId && c.ColorId == colorId
                             select new CarDetailDTO()
                             {
                                 Id = c.Id, 
                                 BrandName = b.BrandName, 
                                 CarName = c.CarName, 
                                 ColorName = cl.ColorName, 
                                 DailyPrice = c.DailyPrice, 
                                 Description = c.Description, 
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();
            }
        }

        public CarDetailDTO GetCarDetailById(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = (from c in context.Cars
                              join b in context.Brands
                              on c.BrandId equals b.BrandId
                              join cl in context.Colors
                              on c.ColorId equals cl.ColorId
                              where c.Id == id
                              select new CarDetailDTO
                              {
                                  Id = c.Id,
                                  CarName = c.CarName,
                                  BrandName = b.BrandName,
                                  ColorName = cl.ColorName,
                                  DailyPrice = c.DailyPrice,
                                  ModelYear = c.ModelYear,
                                  Description = c.Description

                              }).FirstOrDefault();
                return result;
            }
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDTO
                             {
                                 Id = c.Id,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description

                             };
                return result.ToList();
            }
        }

        public List<CarsByBrandIdDto> GetCarsByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             where b.BrandId == brandId
                             select new CarsByBrandIdDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }

        public List<CarsByCarImageDto> GetCarsByCarImage(int carId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join ci in context.CarImages
                             on c.Id equals ci.CarId
                             where ci.CarId == carId
                             select new CarsByCarImageDto
                             {
                                 ImagePath = ci.ImagePath,
                                 Id = ci.Id,
                                 CarId = c.Id
                             };
                return result.ToList();
            }
        }

        public List<CarsByColorIdDto> GetCarsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             where cl.ColorId == colorId
                             select new CarsByColorIdDto { CarName = c.CarName, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear, Description = c.Description };
                return result.ToList();
            }
        }
    }
}
