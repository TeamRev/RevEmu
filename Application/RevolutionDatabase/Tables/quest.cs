using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class quest {
        public quest() { }
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual int seriesNumber { get; set; }
        public virtual int goalType { get; set; }
        public virtual int goalData { get; set; }
        public virtual int reward { get; set; }
        public virtual string dataBit { get; set; }
    }
}
