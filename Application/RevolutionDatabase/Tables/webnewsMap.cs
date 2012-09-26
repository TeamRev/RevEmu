using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class webnewsMap : ClassMap<webnews> {
        
        public webnewsMap() {
			Table("webnews");
			LazyLoad();
			CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.category, "category");
			Map(x => x.title).Column("title").Not.Nullable();
			Map(x => x.body).Column("body").Not.Nullable();
			Map(x => x.created).Column("created").Not.Nullable();
			Map(x => x.spoiler).Column("spoiler").Not.Nullable();
			Map(x => x.image).Column("image").Not.Nullable();
        }
    }
}
