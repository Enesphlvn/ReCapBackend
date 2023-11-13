using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarDal _carDal;
        public RentalManager(IRentalDal rentalDal, ICarDal carDal)
        {
            _rentalDal = rentalDal;
            _carDal = carDal;
        }

        [SecuredOperation("rental.add,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            Random random = new Random();
            int findexScore = random.Next(0, 1901);

            Car car = _carDal.Get(c => c.Id == rental.CarId);
            if(car == null )
            {
                return new ErrorResult(Messages.CarNotFound);
            }

            if(findexScore < car.FindexScore)
            {
                return new ErrorResult(Messages.FindexScoreIsNotEnough);
            }

            var rentals = _rentalDal.GetAll(r => r.CarId == rental.CarId).OrderByDescending(r => r.RentDate).FirstOrDefault(); ;
            
            if(rentals != null)
            {

                if (rentals.ReturnDate > rental.RentDate)
                {
                    return new ErrorResult(Messages.CarWasRentedByElse);
                }

                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);

            }
            try
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            catch
            {

                return new ErrorResult(Messages.RentalNotFound);
            }
            
        }

        [SecuredOperation("rental.delete,admin")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int carId)
        {
            var rentals = _rentalDal.GetAll(r => r.CarId == carId);
            var rentalWithMaxRendDate = rentals.OrderByDescending(r => r.RentDate).FirstOrDefault();
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        [SecuredOperation("rental.update,admin")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
