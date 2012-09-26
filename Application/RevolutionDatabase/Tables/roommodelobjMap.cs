using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roommodelobjMap : ClassMap<roommodelobj> {
        
        public roommodelobjMap() {
			Table("roommodelobjs");
			LazyLoad();
			Id(x => x.model).GeneratedBy.Assigned().Column("model");
			Map(x => x.x).Column("x").Not.Nullable();
			Map(x => x.y).Column("y").Not.Nullable();
			Map(x => x.z).Column("z").Not.Nullable();
			Map(x => x.rotation).Column("rotation").Not.Nullable();
			Map(x => x.content).Column("content").Not.Nullable();
        }
    }
}
