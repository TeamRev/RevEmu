using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class usersubscriptionMap : ClassMap<usersubscription> {
        
        public usersubscriptionMap() {
			Table("usersubscription");
			LazyLoad();
			Id(x => x.userId).GeneratedBy.Identity().Column("user_id");
			Map(x => x.subscription).Column("subscription").Not.Nullable();
			Map(x => x.activated).Column("activated").Not.Nullable();
			Map(x => x.expire).Column("expire").Not.Nullable();
        }
    }
}
