using DAL.Abstract;
using DAL.EFramework;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Concreate
{
    public class CarDalManager : ICarDal
    {
        List<Car> list;
        public CarDalManager()
        {
            if (list == null)
            {

                list = new List<Car>()
            {
                new Car(){CarName="Mercedes",ID=1},
                new Car(){CarName="Audi",ID=2},
                new Car(){CarName="Ford",ID=3},
                new Car(){CarName="Citroen",ID=4}
            };
            }
        }
        
        public void Add(Car entity)
        {
            list.Add(entity);
        }

        public void Delete(Car entity)
        {
            var bul = list.Where(x => x.ID == entity.ID).FirstOrDefault();
            list.Remove(bul);
            //list.Remove(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ContextBase db=new ContextBase())
            {
                return db.Set<Car>().Where(filter).SingleOrDefault();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ContextBase db=new ContextBase())
            {
                if (filter==null)
                {
                    return db.Cars.ToList();
                }
                return filter == null ? db.Set<Car>().ToList() : db.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetBettweenMinMax(int min, int max)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
