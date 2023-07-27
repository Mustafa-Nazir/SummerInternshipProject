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
    public class DebtManager : IDebtService
    {
        private readonly IDebtDal _debtDal;
        public DebtManager(IDebtDal debtDal)
        {
            _debtDal = debtDal;
        }

        public IResult Add(Debt entity)
        {
            _debtDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Debt entity)
        {
            _debtDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Debt> GetById(int id)
        {
            var result = _debtDal.Get(d => d.Id == id);
            return new SuccessDataResult<Debt>(result); 
        }

        public IDataResult<List<DebtDto>> GetUnpaidDebtDtos()
        {
            var result = _debtDal.GetDebtDtos().Where(d => d.DebtAmount-d.PaidDebt > 0 ).ToList();
            return new SuccessDataResult<List<DebtDto>>(result);
        }

        public IDataResult<List<Debt>> GettAll()
        {
            var result = _debtDal.GetAll();
            return new SuccessDataResult<List<Debt>>(result);
        }

        public IResult Update(Debt entity)
        {
            _debtDal.Update(entity);
            return new SuccessResult();
        }

        public IDataResult<List<DebtDto>> GetPaidDebtDtos()
        {
            var result = _debtDal.GetDebtDtos().Where(d => d.DebtAmount - d.PaidDebt <= 0).ToList();
            return new SuccessDataResult<List<DebtDto>>(result);
        }
    }
}
