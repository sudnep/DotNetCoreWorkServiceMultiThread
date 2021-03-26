using System;

namespace ApplicationCore
{
    public class DocTypeMap
    {
        public int DocTypeMapId { get; set; }
        public int RegistryId { get; set; }
        public string DocType { get; set; }
        public string Description { get; set; }
        public string DestinationFolderName { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDtTm { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}