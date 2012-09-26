using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class bot {
        public bot() { }
        public virtual int id { get; set; }
        public virtual int roomId { get; set; }
        public virtual string name { get; set; }
        public virtual string type { get; set; }
        public virtual string motto { get; set; }
        public virtual string look { get; set; }
        public virtual int x { get; set; }
        public virtual int y { get; set; }
        public virtual double z { get; set; }
        public virtual int rotation { get; set; }
        public virtual string walkMode { get; set; }
        public virtual int minX { get; set; }
        public virtual int minY { get; set; }
        public virtual int maxX { get; set; }
        public virtual int maxY { get; set; }
    }
}
