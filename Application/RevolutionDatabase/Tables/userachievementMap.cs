using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class userachievementMap : ClassMap<userachievement> {
        
        public userachievementMap() {
			Table("userachievements");
			LazyLoad();
			CompositeId().KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.achievementId, "achievement_id");
        }
    }
}
