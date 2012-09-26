using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class roomcategoryMap : ClassMap<roomcategory> {
        
        public roomcategoryMap() {
			Table("roomcategory");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.accessRank).Column("access_rank").Not.Nullable();
			Map(x => x.enabled).Column("enabled").Not.Nullable();
        }
    }
}
