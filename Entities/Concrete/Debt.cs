using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Debt:IEntity
    {
        public int Id { get; set; }
        public int CurrentId { get; set; }
        public decimal DebtAmount { get; set; }
        public decimal PaidDebt { get; set; }
        public DateTime DebtDate { get; set; }
    }
}
