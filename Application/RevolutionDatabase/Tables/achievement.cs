using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class achievement {
        public achievement() { }
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string category { get; set; }
        public virtual int level { get; set; }
        public virtual int rewardPoints { get; set; }
        public virtual int rewardCredits { get; set; }
    }
}
