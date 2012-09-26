using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userbanMap : ClassMap<userban> {
        
        public userbanMap() {
			Table("userbans");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.banId, "ban_id");
        }
    }
}
