using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class usermessengermessageMap : ClassMap<usermessengermessage> {
        
        public usermessengermessageMap() {
			Table("usermessengermessages");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.sender).Column("sender").Not.Nullable();
			Map(x => x.message).Column("message").Not.Nullable();
			Map(x => x.sent).Column("sent").Not.Nullable();
			Map(x => x.readed).Column("readed").Not.Nullable();
        }
    }
}
