﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [SecuredOperation("brand.add,admin")]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        [SecuredOperation("brand.delete,admin")]
        public IResult Delete(int brandId)
        {
            Brand brand = _brandDal.Get(b => b.BrandId == brandId);
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll() , Messages.BrandsListed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var result = new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId), Messages.BrandIdListed);
            if(result.Data != null)
            {
                return result;
            }
            else
            {
                return new ErrorDataResult<Brand>(Messages.BrandIsNull);
            }
        }

        [SecuredOperation("brand.update,admin")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
