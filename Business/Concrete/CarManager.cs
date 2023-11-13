using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarNameExists(car.CarName));
            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 400)
            {
                throw new Exception("");
            }

            Add(car);
            return null;
        }

        [SecuredOperation("car.delete,admin")]
        public IResult Delete(int carId)
        {
            Car car = _carDal.Get(c => c.Id == carId);
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<CarDetailDTO> GetById(int id)
        {
            return new SuccessDataResult<CarDetailDTO>(_carDal.GetCarDetailById(id));
        }

        public IDataResult<List<CarDetailDTO>> GetCarByBrandAndColor(int brandId, int colorId)
        {
            var cars = _carDal.GetCarByBrandAndColor(brandId, colorId);

            if (cars == null || cars.Count == 0)
            {
                return new ErrorDataResult<List<CarDetailDTO>>(Messages.CarNotFoundCriteria);
            }

            return new SuccessDataResult<List<CarDetailDTO>>(cars);
        }


        public IDataResult<List<CarsByBrandIdDto>> GetCarByBrandIdDto(int brandId)
        {
            return new SuccessDataResult<List<CarsByBrandIdDto>>(_carDal.GetCarsByBrandId(brandId));
        }

        public IDataResult<List<CarsByColorIdDto>> GetCarByColorIdDto(int colorId)
        {
            return new SuccessDataResult<List<CarsByColorIdDto>>(_carDal.GetCarsByColorId(colorId));
        }

        [PerformanceAspect(5)]
        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails());
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<CarsByCarImageDto>> GetCarsByCarImage(int carId)
        {
            return new SuccessDataResult<List<CarsByCarImageDto>>(_carDal.GetCarsByCarImage(carId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        [SecuredOperation("car.update,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
