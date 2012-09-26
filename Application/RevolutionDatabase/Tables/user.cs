using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class user {
        public user() { }
        public virtual int id { get; set; }
        public virtual int habboId { get; set; }
        public virtual string ticket { get; set; }
        public virtual string username { get; set; }
        public virtual string figure { get; set; }
        public virtual string gender { get; set; }
        public virtual string motto { get; set; }
        public virtual int credits { get; set; }
        public virtual int rank {get; set; }
        public virtual System.Nullable<int> homeRoom { get; set; }
        public virtual string online { get; set; }
    }
}
