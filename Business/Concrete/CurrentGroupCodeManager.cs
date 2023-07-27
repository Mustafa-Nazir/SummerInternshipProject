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
    public class CurrentGroupCodeManager : ICurrentGroupCodeService
    {
        private readonly ICurrentGroupCodeDal _currentGroupCodeDal;

        public CurrentGroupCodeManager(ICurrentGroupCodeDal currentGroupCodeDal)
        {
            _currentGroupCodeDal = currentGroupCodeDal;
        }

        public IResult Add(CurrentGroupCode entity)
        {
            _currentGroupCodeDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(CurrentGroupCode entity)
        {
            _currentGroupCodeDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<CurrentGroupCode> GetIdByName(string name)
        {
            CurrentGroupCode? result = _currentGroupCodeDal.Get(c => c.Name == name);
            return new SuccessDataResult<CurrentGroupCode>(result);
        }

        public IDataResult<List<CurrentGroupCode>> GettAll()
        {
            var result = _currentGroupCodeDal.GetAll();
            return new SuccessDataResult<List<CurrentGroupCode>>(result);
        }

        public IResult Update(CurrentGroupCode entity)
        {
            _currentGroupCodeDal.Update(entity);
            return new SuccessResult();
        }
    }
}
