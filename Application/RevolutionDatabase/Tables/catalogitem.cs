using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class catalogitem {
        public catalogitem() { }
        public virtual int id { get; set; }
        public virtual int pageId { get; set; }
        public virtual string name { get; set; }
        public virtual int credits { get; set; }
        public virtual int pixels { get; set; }
        public virtual int snow { get; set; }
        public virtual int quantity { get; set; }
    }
}
