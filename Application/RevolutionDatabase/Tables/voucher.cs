using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class voucher {
        public voucher() { }
        public virtual int id { get; set; }
        public virtual string code { get; set; }
        public virtual int credits { get; set; }
        public virtual int itemId { get; set; }
        public virtual int quantity { get; set; }
    }
}
