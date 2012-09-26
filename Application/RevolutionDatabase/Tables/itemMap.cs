using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class itemMap : ClassMap<item> {
        
        public itemMap() {
			Table("items");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.itemName).Column("item_name").Not.Nullable();
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.type).Column("type").Not.Nullable();
			Map(x => x.width).Column("width").Not.Nullable();
			Map(x => x.length).Column("length").Not.Nullable();
			Map(x => x.height).Column("height").Not.Nullable();
			Map(x => x.sprite).Column("sprite").Not.Nullable();
			Map(x => x.stackable).Column("stackable").Not.Nullable();
			Map(x => x.sitable).Column("sitable").Not.Nullable();
			Map(x => x.walkable).Column("walkable").Not.Nullable();
			Map(x => x.recyclable).Column("recyclable").Not.Nullable();
			Map(x => x.tradeable).Column("tradeable").Not.Nullable();
			Map(x => x.sellable).Column("sellable").Not.Nullable();
			Map(x => x.giftable).Column("giftable").Not.Nullable();
			Map(x => x.inventoryStackable).Column("inventory_stackable").Not.Nullable();
			Map(x => x.behaviour).Column("behaviour").Not.Nullable();
			Map(x => x.behaviourCount).Column("behaviour_count").Not.Nullable();
			Map(x => x.vending).Column("vending").Not.Nullable();
        }
    }
}
