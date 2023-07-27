using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CurrentManager : ICurrentService
    {
        private readonly ICurrentDal _currentDal;
        public CurrentManager(ICurrentDal currentDal)
        {
            _currentDal = currentDal;
        }
        public IResult Add(Current entity)
        {
            _currentDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Current entity)
        {
            _currentDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Current> GetByCurrentCodeId(int id)
        {
            var result = _currentDal.Get(c=>c.CurrentCodeId==id);
            return result == null ? new ErrorDataResult<Current>(): new SuccessDataResult<Current>(result); 
        }

        public IDataResult<Current> GetByCurrentName(string name)
        {
            Current? result = _currentDal.Get(c => c.CurrentName == name);
            return result == null ? new ErrorDataResult<Current>() :new SuccessDataResult<Current>(result);
        }

        public IDataResult<CurrentDto> GetCurrentDto(Current current)
        {
            var result = _currentDal.GetCurrentDto(current);
            return new SuccessDataResult<CurrentDto>(result);
        }

        public IDataResult<List<Current>> GettAll()
        {
            var result = _currentDal.GetAll();
            return new SuccessDataResult<List<Current>>(result);
        }

        public IResult Update(Current entity)
        {
            _currentDal.Update(entity);
            return new SuccessResult();
        }
    }
}
