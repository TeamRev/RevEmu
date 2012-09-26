using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userpetMap : ClassMap<userpet> {
        
        public userpetMap() {
			Table("userpets");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.roomId, "room_id");
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.color).Column("color").Not.Nullable();
			Map(x => x.type).Column("type").Not.Nullable();
			Map(x => x.experience).Column("experience").Not.Nullable();
			Map(x => x.energy).Column("energy").Not.Nullable();
			Map(x => x.nutrition).Column("nutrition").Not.Nullable();
			Map(x => x.respects).Column("respects").Not.Nullable();
			Map(x => x.created).Column("created").Not.Nullable();
			Map(x => x.x).Column("x").Not.Nullable();
			Map(x => x.y).Column("y").Not.Nullable();
			Map(x => x.z).Column("z").Not.Nullable();
        }
    }
}
