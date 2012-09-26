using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class habboMap : ClassMap<habbo> {
        
        public habboMap() {
			Table("habbo");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.email).Column("email").Not.Nullable();
			Map(x => x.realName).Column("real_name").Not.Nullable();
			Map(x => x.password).Column("password").Not.Nullable();
			Map(x => x.dob).Column("dob").Not.Nullable();
			Map(x => x.ip).Column("ip").Not.Nullable();
			Map(x => x.country).Column("country").Not.Nullable();
			Map(x => x.language).Column("language").Not.Nullable();
        }
    }
}
