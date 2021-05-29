using BLL.Abstract;
using BLL.Constans;
using Core.Utilities.Results;
using DAL.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Concreate.EntityFramework
{
    public class CarService : ICarCervice
    {
        ICarDal _carDal;

        public CarService(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
           return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);

            }
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(x => x.BrandID == brandId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesDataResult<Car>(Messages.CarUpdated);
        }
    }
}
