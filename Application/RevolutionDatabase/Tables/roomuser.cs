using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class roomuser {
        public roomuser() { }
        public virtual int roomId { get; set; }
        public virtual int active { get; set; }
        public virtual int max { get; set; }
    }
}
