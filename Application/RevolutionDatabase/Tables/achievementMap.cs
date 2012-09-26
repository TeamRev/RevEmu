using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class achievementMap : ClassMap<achievement> {
        
        public achievementMap() {
			Table("achievements");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.category).Column("category").Not.Nullable();
			Map(x => x.level).Column("level").Not.Nullable();
			Map(x => x.rewardPoints).Column("reward_points").Not.Nullable();
			Map(x => x.rewardCredits).Column("reward_credits").Not.Nullable();
        }
    }
}
