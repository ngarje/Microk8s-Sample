using System;

namespace MicroK8s.Api.Database.Domain
{
    public class CountryEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public RegionEntity Region { get; set; }
    }
}