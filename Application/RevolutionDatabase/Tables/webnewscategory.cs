using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class webnewscategory {
        public webnewscategory() { }
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string description { get; set; }
    }
}
