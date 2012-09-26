using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class chatfilterMap : ClassMap<chatfilter> {
        
        public chatfilterMap() {
			Table("chatfilter");
			LazyLoad();
			Id(x => x.word).GeneratedBy.Assigned().Column("word");
			Map(x => x.filter).Column("filter").Not.Nullable();
        }
    }
}
