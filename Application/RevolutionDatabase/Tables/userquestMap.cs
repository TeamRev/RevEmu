using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userquestMap : ClassMap<userquest> {
        
        public userquestMap() {
			Table("userquests");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.questId, "quest_id");
			Map(x => x.progress).Column("progress").Not.Nullable();
        }
    }
}
