using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class useritemmoodlightMap : ClassMap<useritemmoodlight> {
        
        public useritemmoodlightMap() {
			Table("useritemmoodlights");
			LazyLoad();
			Id(x => x.itemId).GeneratedBy.Identity().Column("item_id");
			Map(x => x.enabled).Column("enabled").Not.Nullable();
			Map(x => x.currentPreset).Column("current_preset").Not.Nullable();
			Map(x => x.presetOne).Column("preset_one").Not.Nullable();
			Map(x => x.presetTwo).Column("preset_two").Not.Nullable();
			Map(x => x.presetThree).Column("preset_three").Not.Nullable();
        }
    }
}
