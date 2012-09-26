using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class webnewscategoryMap : ClassMap<webnewscategory> {
        
        public webnewscategoryMap() {
			Table("webnewscategory");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.description).Column("description").Not.Nullable();
        }
    }
}
