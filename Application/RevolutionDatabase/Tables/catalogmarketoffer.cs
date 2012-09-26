using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class catalogmarketoffer {
        public catalogmarketoffer() { }
        public virtual int offerId { get; set; }
        public virtual int buyerId { get; set; }
        public virtual byte[] created { get; set; }
        public virtual int offering { get; set; }
    }
}
