using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();
        List<CarsByBrandIdDto> GetCarsByBrandId(int brandId);
        List<CarsByColorIdDto> GetCarsByColorId(int colorId);
        List<CarsByCarImageDto> GetCarsByCarImage(int carId);
        CarDetailDTO GetCarDetailById(int id);
        List<CarDetailDTO> GetCarByBrandAndColor(int brandId, int colorId);
    }
}
