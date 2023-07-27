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
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country entity)
        {
            _countryDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Country entity)
        {
            _countryDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<int>? GetIdByName(string name)
        {
            var result = _countryDal.Get(c => c.Name == name).Id;
            return new SuccessDataResult<int>(result);
        }

        public IDataResult<List<Country>> GettAll()
        {
            var result = _countryDal.GetAll();
            return new SuccessDataResult<List<Country>>(result);
        }

        public IResult Update(Country entity)
        {
            _countryDal.Update(entity);
            return new SuccessResult();
        }
    }
}
