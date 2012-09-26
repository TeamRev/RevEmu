using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userwardrobeMap : ClassMap<userwardrobe> {
        
        public userwardrobeMap() {
			Table("userwardrobe");
			LazyLoad();
			Id(x => x.userId).GeneratedBy.Identity().Column("user_id");
			Map(x => x.slotId).Column("slot_id").Not.Nullable();
			Map(x => x.figure).Column("figure").Not.Nullable();
			Map(x => x.gender).Column("gender").Not.Nullable();
        }
    }
}
