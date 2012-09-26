using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userMap : ClassMap<user> {
        
        public userMap() {
			Table("users");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.habboId, "habbo_id").KeyProperty(x => x.ticket, "ticket");
			Map(x => x.username).Column("username").Not.Nullable();
			Map(x => x.figure).Column("figure").Not.Nullable();
			Map(x => x.gender).Column("gender").Not.Nullable();
			Map(x => x.motto).Column("motto").Not.Nullable();
			Map(x => x.credits).Column("credits").Not.Nullable();
			Map(x => x.homeRoom).Column("home_room");
			Map(x => x.online).Column("online").Not.Nullable();
        }
    }
}
