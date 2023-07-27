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
    public interface ICurrentService:IBaseService<Current>
    {
        IDataResult<Current> GetByCurrentName(string name);
        IDataResult<Current> GetByCurrentCodeId(int id);
        IDataResult<CurrentDto> GetCurrentDto(Current current);
    }
}
