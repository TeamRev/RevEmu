using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roompublicMap : ClassMap<roompublic> {
        
        public roompublicMap() {
			Table("roompublic");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.roomId, "room_id");
			Map(x => x.orderId).Column("order_id").Not.Nullable();
			Map(x => x.banner).Column("banner").Not.Nullable();
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.image).Column("image").Not.Nullable();
			Map(x => x.category).Column("category").Not.Nullable();
			Map(x => x.categoryParent).Column("category_parent").Not.Nullable();
        }
    }
}
