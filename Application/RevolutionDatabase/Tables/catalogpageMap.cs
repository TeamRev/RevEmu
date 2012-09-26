using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class catalogpageMap : ClassMap<catalogpage> {
        
        public catalogpageMap() {
			Table("catalogpages");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.parentId).Column("parent_id").Not.Nullable();
			Map(x => x.orderId).Column("order_id").Not.Nullable();
			Map(x => x.name).Column("name").Not.Nullable();
			Map(x => x.accessRank).Column("access_rank").Not.Nullable();
			Map(x => x.iconImage).Column("icon_image").Not.Nullable();
			Map(x => x.iconColor).Column("icon_color").Not.Nullable();
			Map(x => x.layout).Column("layout").Not.Nullable();
			Map(x => x.imgHeadline).Column("img_headline").Not.Nullable();
			Map(x => x.imgTeaser).Column("img_teaser").Not.Nullable();
			Map(x => x.special).Column("special").Not.Nullable();
			Map(x => x.textOne).Column("text_one").Not.Nullable();
			Map(x => x.textTwo).Column("text_two").Not.Nullable();
			Map(x => x.textDetails).Column("text_details").Not.Nullable();
			Map(x => x.textTeaser).Column("text_teaser").Not.Nullable();
        }
    }
}
