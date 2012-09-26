using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class chatfilter {
        public chatfilter() { }
        public virtual string word { get; set; }
        public virtual string filter { get; set; }
    }
}
