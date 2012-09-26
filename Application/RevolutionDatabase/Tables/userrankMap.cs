using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userrankMap : ClassMap<userrank> {
        
        public userrankMap() {
			Table("userranks");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.rank).Column("rank").Not.Nullable();
        }
    }
}
