using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class habbo {
        public habbo() { }
        public virtual int id { get; set; }
        public virtual string email { get; set; }
        public virtual string realName { get; set; }
        public virtual string password { get; set; }
        public virtual System.DateTime dob { get; set; }
        public virtual string ip { get; set; }
        public virtual string country { get; set; }
        public virtual string language { get; set; }
    }
}
