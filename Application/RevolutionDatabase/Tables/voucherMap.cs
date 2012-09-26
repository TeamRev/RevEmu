using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class voucherMap : ClassMap<voucher> {
        
        public voucherMap() {
			Table("vouchers");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.code).Column("code").Not.Nullable();
			Map(x => x.credits).Column("credits").Not.Nullable();
			Map(x => x.itemId).Column("item_id").Not.Nullable();
			Map(x => x.quantity).Column("quantity").Not.Nullable();
        }
    }
}
