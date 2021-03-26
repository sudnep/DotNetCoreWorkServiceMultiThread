using System;

namespace ApplicationCore
{
    public class EntityCodeMap
    {
        public int EntityCodeMapId { get; set; }
        public string EntityCode { get; set; }
        public string Fund { get; set; }
        public string FundManager { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDtTm { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}