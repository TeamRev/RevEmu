using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class questMap : ClassMap<quest> {
        
        public questMap() {
			Table("quests");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.seriesNumber).Column("series_number").Not.Nullable();
			Map(x => x.goalType).Column("goal_type").Not.Nullable();
			Map(x => x.goalData).Column("goal_data").Not.Nullable();
			Map(x => x.reward).Column("reward").Not.Nullable();
			Map(x => x.dataBit).Column("data_bit").Not.Nullable();
        }
    }
}
