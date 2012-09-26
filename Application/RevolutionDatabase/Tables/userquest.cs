using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class userquest {
        public userquest() { }
        public virtual int userId { get; set; }
        public virtual int questId { get; set; }
        public virtual int progress { get; set; }
    }
}
