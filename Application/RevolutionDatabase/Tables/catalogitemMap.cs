using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class catalogitemMap : ClassMap<catalogitem> {
        
        public catalogitemMap() {
			Table("catalogitems");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.pageId).Column("page_id").Not.Nullable();
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.credits).Column("credits").Not.Nullable();
			Map(x => x.pixels).Column("pixels").Not.Nullable();
			Map(x => x.snow).Column("snow").Not.Nullable();
			Map(x => x.quantity).Column("quantity").Not.Nullable();
        }
    }
}
