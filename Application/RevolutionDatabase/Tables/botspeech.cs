using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class botspeech {
        public botspeech() { }
        public virtual int id { get; set; }
        public virtual int botId { get; set; }
        public virtual string speech { get; set; }
        public virtual string shout { get; set; }
    }
}
