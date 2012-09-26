using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class usermessengerfriend {
        public usermessengerfriend() { }
        public virtual int userId { get; set; }
        public virtual int friendId { get; set; }
        public virtual string accepted { get; set; }
    }
}
