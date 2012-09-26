using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roomMap : ClassMap<room> {
        
        public roomMap() {
			Table("rooms");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.category, "category");
			Map(x => x.ownerId).Column("owner_id").Not.Nullable();
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.description).Column("description").Not.Nullable();
			Map(x => x.model).Column("model").Not.Nullable();
			Map(x => x.state).Column("state").Not.Nullable();
			Map(x => x.password).Column("password").Not.Nullable();
			Map(x => x.wallpaper).Column("wallpaper").Not.Nullable();
			Map(x => x.wallsize).Column("wallsize").Not.Nullable();
			Map(x => x.floor).Column("floor").Not.Nullable();
			Map(x => x.floorsize).Column("floorsize").Not.Nullable();
			Map(x => x.score).Column("score").Not.Nullable();
			Map(x => x.tags).Column("tags").Not.Nullable();
			Map(x => x.iconBg).Column("icon_bg").Not.Nullable();
			Map(x => x.iconFg).Column("icon_fg").Not.Nullable();
			Map(x => x.iconItems).Column("icon_items").Not.Nullable();
        }
    }
}
