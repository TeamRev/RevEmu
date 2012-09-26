using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roomuserMap : ClassMap<roomuser> {
        
        public roomuserMap() {
			Table("roomusers");
			LazyLoad();
			Id(x => x.roomId).GeneratedBy.Identity().Column("room_id");
			Map(x => x.active).Column("active").Not.Nullable();
			Map(x => x.max).Column("max").Not.Nullable();
        }
    }
}
