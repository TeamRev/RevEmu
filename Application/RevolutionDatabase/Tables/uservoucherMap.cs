using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class uservoucherMap : ClassMap<uservoucher> {
        
        public uservoucherMap() {
			Table("uservouchers");
			LazyLoad();
			base.CompositeId().KeyProperty(x => x.userId, "user_id").KeyProperty(x => x.voucherId, "voucher_id");
        }
    }
}
