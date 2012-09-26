using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class userpet {
        public userpet() { }
        public virtual int id { get; set; }
        public virtual int userId { get; set; }
        public virtual int roomId { get; set; }
        public virtual string name { get; set; }
        public virtual string color { get; set; }
        public virtual int type { get; set; }
        public virtual int experience { get; set; }
        public virtual int energy { get; set; }
        public virtual int nutrition { get; set; }
        public virtual int respects { get; set; }
        public virtual byte[] created { get; set; }
        public virtual int x { get; set; }
        public virtual int y { get; set; }
        public virtual double z { get; set; }
    }
}
