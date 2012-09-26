using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class usermessengermessage {
        public usermessengermessage() { }
        public virtual int id { get; set; }
        public virtual int sender { get; set; }
        public virtual string message { get; set; }
        public virtual byte[] sent { get; set; }
        public virtual string readed { get; set; }
    }
}
