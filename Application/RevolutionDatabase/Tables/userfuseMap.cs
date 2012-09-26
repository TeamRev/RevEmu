using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userfuseMap : ClassMap<userfuse> {
        
        public userfuseMap() {
			Table("userfuse");
			LazyLoad();
			Id(x => x.fuse).GeneratedBy.Assigned().Column("fuse");
        }
    }
}
