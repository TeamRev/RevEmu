using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class countryfilterMap : ClassMap<countryfilter> {
        
        public countryfilterMap() {
			Table("countryfilter");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.country).Column("country").Not.Nullable();
        }
    }
}
