using Core.DataAccess;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract
{
   public interface ICarDal:IBaseRepository<Car>
    {

        List<Car> GetBettweenMinMax (int min,int max);
        
    }
}
