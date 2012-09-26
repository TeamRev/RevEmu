using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class catalogmarketitemMap : ClassMap<catalogmarketitem> {
        
        public catalogmarketitemMap() {
			Table("catalogmarketitems");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.sellerId).Column("seller_id").Not.Nullable();
			Map(x => x.itemId).Column("item_id").Not.Nullable();
			Map(x => x.asking).Column("asking").Not.Nullable();
			Map(x => x.created).Column("created").Not.Nullable();
			Map(x => x.state).Column("state").Not.Nullable();
        }
    }
}
