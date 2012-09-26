using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class chatlog {
        public chatlog() { }
        public virtual int id { get; set; }
        public virtual int userId { get; set; }
        public virtual int roomId { get; set; }
        public virtual string message { get; set; }
        public virtual byte[] created { get; set; }
    }
}
