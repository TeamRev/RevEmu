using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class userban {
        public userban() { }
        public virtual int userId { get; set; }
        public virtual int banId { get; set; }
    }
}
