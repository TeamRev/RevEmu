using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class chatlogMap : ClassMap<chatlog> {
        
        public chatlogMap() {
			Table("chatlogs");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.userId).Column("user_id").Not.Nullable();
			Map(x => x.roomId).Column("room_id").Not.Nullable();
			Map(x => x.message).Column("message").Not.Nullable();
			Map(x => x.created).Column("created").Not.Nullable();
        }
    }
}
