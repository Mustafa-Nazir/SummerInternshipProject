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
    public class CurrentCodeManager : ICurrentCodeService
    {
        private readonly ICurrentCodeDal _currentCodeDal;

        public CurrentCodeManager(ICurrentCodeDal currentCodeDal)
        {
            _currentCodeDal = currentCodeDal;
        }

        public IResult Add(CurrentCode entity)
        {
            _currentCodeDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(CurrentCode entity)
        {
            _currentCodeDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<CurrentCode>? GetIdByName(string name)
        {
            CurrentCode? result = _currentCodeDal.Get(c => c.Name == name);
            return new SuccessDataResult<CurrentCode>(result);
        }

        public IDataResult<CurrentCode>? GetNameById(int id)
        {
            var result = _currentCodeDal.Get(c => c.Id == id);
            return new SuccessDataResult<CurrentCode>(result);
        }

        public IDataResult<List<CurrentCode>> GettAll()
        {
            var result = _currentCodeDal.GetAll();
            return new SuccessDataResult<List<CurrentCode>>(result);

        }

        public IResult Update(CurrentCode entity)
        {
            _currentCodeDal.Update(entity);
            return new SuccessResult();
        }
    }
}
