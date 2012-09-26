using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class useritemnote {
        public useritemnote() { }
        public virtual int roomId { get; set; }
        public virtual string date { get; set; }
        public virtual string content { get; set; }
    }
}
