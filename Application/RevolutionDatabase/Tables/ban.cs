using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class ban {
        public ban() { }
        public virtual int id { get; set; }
        public virtual int issuerId { get; set; }
        public virtual string reason { get; set; }
        public virtual byte[] expire { get; set; }
    }
}
