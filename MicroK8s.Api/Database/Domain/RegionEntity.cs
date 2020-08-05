using System.Collections.Generic;

namespace MicroK8s.Api.Database.Domain
{
    public class RegionEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<CountryEntity> Countries { get; set; }
    }
}