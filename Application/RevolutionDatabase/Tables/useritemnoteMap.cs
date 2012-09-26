using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class useritemnoteMap : ClassMap<useritemnote> {
        
        public useritemnoteMap() {
			Table("useritemnotes");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.roomId, "room_id").KeyProperty(x => x.date, "date");
			Map(x => x.content).Column("content").Not.Nullable();
        }
    }
}
