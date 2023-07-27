using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDebtService:IBaseService<Debt>
    {
        IDataResult<List<DebtDto>> GetUnpaidDebtDtos();
        IDataResult<List<DebtDto>> GetPaidDebtDtos();
        IDataResult<Debt> GetById(int id);
    }
}
