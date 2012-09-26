using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class roommodelobj {
        public roommodelobj() { }
        public virtual string model { get; set; }
        public virtual int x { get; set; }
        public virtual int y { get; set; }
        public virtual double z { get; set; }
        public virtual int rotation { get; set; }
        public virtual string content { get; set; }
    }
}
