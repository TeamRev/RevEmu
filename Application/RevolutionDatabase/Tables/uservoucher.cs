using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class uservoucher {
        public uservoucher() { }
        public virtual int userId { get; set; }
        public virtual int voucherId { get; set; }
    }
}
