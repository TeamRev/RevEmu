using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class usersubscription {
        public usersubscription() { }
        public virtual int userId { get; set; }
        public virtual string subscription { get; set; }
        public virtual byte[] activated { get; set; }
        public virtual byte[] expire { get; set; }
    }
}
