using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IDataResult<List<CarsByBrandIdDto>> GetCarByBrandIdDto(int brandId);
        IDataResult<List<CarsByColorIdDto>> GetCarByColorIdDto(int colorId);
        IDataResult<List<CarsByCarImageDto>> GetCarsByCarImage(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult AddTransactionalTest(Car car);
        IDataResult<CarDetailDTO> GetById(int id);
        IDataResult<List<CarDetailDTO>> GetCarByBrandAndColor(int brandId, int colorId);
    }
}
