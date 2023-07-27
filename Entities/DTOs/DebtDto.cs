using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DebtDto:IDto
    {
        public int DebtId { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string Authorized { get; set; }
        public string AuthorizedMail { get; set; }
        public decimal DebtAmount { get; set; }
        public decimal PaidDebt { get; set; }
        public DateTime DebtDate { get; set; }
    }
}
