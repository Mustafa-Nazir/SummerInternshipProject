using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CurrentDto:IDto
    {
        public int Id { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentGroupCode { get; set; }
        public string CurrentGroupName { get; set; }
        public string CurrentName { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public string EMail { get; set; }
        public string Authorized { get; set; }
        public string AuthorizedMail { get; set; }
    }
}
