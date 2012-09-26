using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class botMap : ClassMap<bot> {
        
        public botMap() {
			Table("bots");
			LazyLoad();
			CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.roomId, "room_id");
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.type).Column("type").Not.Nullable();
			Map(x => x.motto).Column("motto").Not.Nullable();
			Map(x => x.look).Column("look").Not.Nullable();
			Map(x => x.x).Column("x").Not.Nullable();
			Map(x => x.y).Column("y").Not.Nullable();
			Map(x => x.z).Column("z").Not.Nullable();
			Map(x => x.rotation).Column("rotation").Not.Nullable();
			Map(x => x.walkMode).Column("walk_mode").Not.Nullable();
			Map(x => x.minX).Column("min_x").Not.Nullable();
			Map(x => x.minY).Column("min_y").Not.Nullable();
			Map(x => x.maxX).Column("max_x").Not.Nullable();
			Map(x => x.maxY).Column("max_y").Not.Nullable();
        }
    }
}
