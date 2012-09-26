using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class userachievement {
        public userachievement() { }
        public virtual int userId { get; set; }
        public virtual int achievementId { get; set; }
    }
}
