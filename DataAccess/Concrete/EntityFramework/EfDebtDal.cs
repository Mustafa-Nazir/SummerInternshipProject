using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDebtDal:EfEntityRepositoryBase<Debt,CurrentProccessContext>,IDebtDal
    {
        public List<DebtDto> GetDebtDtos()
        {
            using (CurrentProccessContext context = new())
            {
                var result = from debt in context.Debts
                             join curr in context.Currents
                             on debt.CurrentId equals curr.Id
                             join currCode in context.CurrentCodes
                             on curr.CurrentCodeId equals currCode.Id
                             select new DebtDto
                             {
                                 Authorized = curr.Authorized,
                                 AuthorizedMail = curr.AuthorizedMail,
                                 CurrentCode = currCode.Name,
                                 CurrentName = curr.CurrentName,
                                 DebtAmount = debt.DebtAmount,
                                 DebtDate = debt.DebtDate,
                                 PaidDebt = debt.PaidDebt,
                                 DebtId = debt.Id
                             };
                return result.ToList();
            }
        }
    }
}
