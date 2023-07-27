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
    public class DistrictManager : IDistrictService
    {
        private readonly IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IResult Add(District entity)
        {
            _districtDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(District entity)
        {
            _districtDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<District>> GetByCityId(int Id)
        {
            var result = _districtDal.GetAll(d => d.CityId == Id);
            return new SuccessDataResult<List<District>>(result);
        }

        public IDataResult<int> GetCityIdByName(string name)
        {
            var result = _districtDal.Get(d => d.Name == name).Id;
            return new SuccessDataResult<int>(result);
        }

        public IDataResult<int> GetIdByName(string name)
        {
            var result = _districtDal.Get(d => d.Name == name).Id;
            return new SuccessDataResult<int>(result);
        }

        public IDataResult<List<District>> GettAll()
        {
            var result = _districtDal.GetAll();
            return new SuccessDataResult<List<District>>(result);
        }

        public IResult Update(District entity)
        {
            _districtDal.Update(entity);
            return new SuccessResult();
        }
    }
}
