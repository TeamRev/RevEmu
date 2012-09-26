using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roomrightMap : ClassMap<roomright> {
        
        public roomrightMap() {
			Table("roomrights");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.roomId, "room_id");
        }
    }
}
