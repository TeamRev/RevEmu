using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class catalogmarketofferMap : ClassMap<catalogmarketoffer> {
        
        public catalogmarketofferMap() {
			Table("catalogmarketoffers");
			LazyLoad();
			CompositeId().KeyProperty(x => x.offerId, "offer_id").KeyProperty(x => x.buyerId, "buyer_id");
			Map(x => x.created).Column("created").Not.Nullable();
			Map(x => x.offering).Column("offering").Not.Nullable();
        }
    }
}
