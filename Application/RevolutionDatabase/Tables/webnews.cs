using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class webnews {
        public webnews() { }
        public virtual int id { get; set; }
        public virtual int category { get; set; }
        public virtual string title { get; set; }
        public virtual string body { get; set; }
        public virtual byte[] created { get; set; }
        public virtual string spoiler { get; set; }
        public virtual string image { get; set; }
    }
}
