using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class roomcategory {
        public roomcategory() { }
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual int accessRank { get; set; }
        public virtual string enabled { get; set; }
    }
}
