using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class roomright {
        public roomright() { }
        public virtual int userId { get; set; }
        public virtual int roomId { get; set; }
    }
}
