using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class botresponseMap : ClassMap<botresponse> {
        
        public botresponseMap() {
			Table("botresponse");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.botId).Column("bot_id").Not.Nullable();
			Map(x => x.keywords).Column("keywords").Not.Nullable();
			Map(x => x.response).Column("response").Not.Nullable();
			Map(x => x.mode).Column("mode").Not.Nullable();
        }
    }
}
