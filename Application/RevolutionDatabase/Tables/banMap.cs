using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class banMap : ClassMap<ban> {
        
        public banMap() {
			Table("bans");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.issuerId, "issuer_id");
			Map(x => x.reason).Column("reason").Not.Nullable();
			Map(x => x.expire).Column("expire").Not.Nullable();
        }
    }
}
