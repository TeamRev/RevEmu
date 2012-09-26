using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class itemteleconnMap : ClassMap<itemteleconn> {
        
        public itemteleconnMap() {
			Table("itemteleconn");
			LazyLoad();
			Id(x => x.itemOne).GeneratedBy.Identity().Column("item_one");
			Map(x => x.itemTwo).Column("item_two").Not.Nullable();
        }
    }
}
