using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class usermessengerfriendMap : ClassMap<usermessengerfriend> {
        
        public usermessengerfriendMap() {
			Table("usermessengerfriend");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.friendId, "friend_id");
			Map(x => x.accepted).Column("accepted").Not.Nullable();
        }
    }
}
