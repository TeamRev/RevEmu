using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class userwardrobe {
        public userwardrobe() { }
        public virtual int userId { get; set; }
        public virtual int slotId { get; set; }
        public virtual string figure { get; set; }
        public virtual string gender { get; set; }
    }
}
