using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City entity)
        {
            _cityDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(City entity)
        {
            _cityDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<City>> GetByCountryId(int Id)
        {
            var result = _cityDal.GetAll(c => c.CountryId == Id);
            return new SuccessDataResult<List<City>>(result);
        }

        public IDataResult<City> GetById(int Id)
        {
            var result = _cityDal.Get(c => c.Id == Id);
            return new SuccessDataResult<City>(result);
        }

        public IDataResult<int> GetIdByName(string name)
        {
            var result = _cityDal.Get(c => c.Name == name).Id;
            return new SuccessDataResult<int>(result);
        }

        public IDataResult<List<City>> GettAll()
        {
            var result = _cityDal.GetAll();
            return new SuccessDataResult<List<City>>(result);
        }

        public IResult Update(City entity)
        {
            _cityDal.Update(entity);
            return new SuccessResult();
        }
    }
}
