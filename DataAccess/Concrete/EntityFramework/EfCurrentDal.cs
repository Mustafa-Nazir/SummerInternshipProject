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
    public class EfCurrentDal : EfEntityRepositoryBase<Current, CurrentProccessContext>, ICurrentDal
    {
        public CurrentDto GetCurrentDto(Current current)
        {
            using (CurrentProccessContext context = new())
            {
                var result = from cur in context.Currents
                             where cur.Id == current.Id
                             join count in context.Countries
                             on cur.CountryId equals count.Id
                             join city in context.Cities
                             on cur.CityId equals city.Id
                             join dis in context.Districts
                             on cur.DistrictId equals dis.Id
                             join currCode in context.CurrentCodes
                             on cur.CurrentCodeId equals currCode.Id
                             join currGroupCode in context.CurrentGroupCodes
                             on cur.CurrentGroupCodeId equals currGroupCode.Id
                             select new CurrentDto 
                             {
                                 Id = cur.Id,
                                 Address = cur.Address,
                                 Authorized = cur.Authorized,
                                 AuthorizedMail = cur.AuthorizedMail,
                                 City = city.Name,
                                 Country = count.Name,
                                 CurrentCode = currCode.Name,
                                 CurrentGroupCode = currGroupCode.Name,
                                 CurrentGroupName = cur.CurrentGroupName,
                                 CurrentName = cur.CurrentName,
                                 District = dis.Name,
                                 EMail = cur.EMail,
                                 Phone = cur.Phone,
                                 TaxAdministration = cur.TaxAdministration,
                                 TaxNo = cur.TaxNo,
                                 WebAddress = cur.WebAddress 
                             };
                var resultList = result.ToList();
                return resultList[0];
            }
        }
    }
}
