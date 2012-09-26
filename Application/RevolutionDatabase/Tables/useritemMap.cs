using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class useritemMap : ClassMap<useritem> {
        
        public useritemMap() {
			Table("useritems");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.roomId, "room_id");
			Map(x => x.itemId).Column("item_id").Not.Nullable();
			Map(x => x.extraData).Column("extra_data").Not.Nullable();
			Map(x => x.x).Column("x").Not.Nullable();
			Map(x => x.y).Column("y").Not.Nullable();
			Map(x => x.z).Column("z").Not.Nullable();
			Map(x => x.rotation).Column("rotation").Not.Nullable();
			Map(x => x.wallPosition).Column("wall_position").Not.Nullable();
        }
    }
}
