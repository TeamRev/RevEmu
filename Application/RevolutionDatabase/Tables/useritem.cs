using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class useritem {
        public useritem() { }
        public virtual int id { get; set; }
        public virtual int userId { get; set; }
        public virtual int roomId { get; set; }
        public virtual int itemId { get; set; }
        public virtual string extraData { get; set; }
        public virtual int x { get; set; }
        public virtual int y { get; set; }
        public virtual double z { get; set; }
        public virtual int rotation { get; set; }
        public virtual string wallPosition { get; set; }
    }
}
