using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class catalogmarketitem {
        public catalogmarketitem() { }
        public virtual int id { get; set; }
        public virtual int sellerId { get; set; }
        public virtual int itemId { get; set; }
        public virtual int asking { get; set; }
        public virtual byte[] created { get; set; }
        public virtual string state { get; set; }
    }
}
