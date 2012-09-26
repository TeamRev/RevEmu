using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class botresponse {
        public botresponse() { }
        public virtual int id { get; set; }
        public virtual int botId { get; set; }
        public virtual string keywords { get; set; }
        public virtual string response { get; set; }
        public virtual string mode { get; set; }
    }
}
