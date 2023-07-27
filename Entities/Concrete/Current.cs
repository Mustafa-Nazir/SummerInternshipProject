using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Current:IEntity
    {
        public int Id { get; set; }
        public int CurrentCodeId { get; set; }
        public int CurrentGroupCodeId { get; set; }
        public string CurrentGroupName { get; set; }
        public string CurrentName { get; set; }
        public string TaxAdministration {get;set;}
        public string TaxNo { get;set;}
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public string EMail { get;  set; }
        public string Authorized { get; set; }
        public string AuthorizedMail { get; set; }
    }
}
