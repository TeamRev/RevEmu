using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class roompublic {
        public roompublic() { }
        public virtual int id { get; set; }
        public virtual int roomId { get; set; }
        public virtual int orderId { get; set; }
        public virtual string banner { get; set; }
        public virtual string name { get; set; }
        public virtual string image { get; set; }
        public virtual int category { get; set; }
        public virtual int categoryParent { get; set; }
    }
}
