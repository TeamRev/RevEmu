using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roommodelMap : ClassMap<roommodel> {
        
        public roommodelMap() {
			Table("roommodels");
			LazyLoad();
			Id(x => x.model).GeneratedBy.Assigned().Column("model");
			Map(x => x.doorX).Column("door_x").Not.Nullable();
			Map(x => x.doorY).Column("door_y").Not.Nullable();
			Map(x => x.doorZ).Column("door_z").Not.Nullable();
			Map(x => x.heightmap).Column("heightmap").Not.Nullable();
			Map(x => x.publicItems).Column("public_items").Not.Nullable();
			Map(x => x.clubOnly).Column("club_only").Not.Nullable();
        }
    }
}
