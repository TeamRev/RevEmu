using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class countryfilter {
        public countryfilter() { }
        public virtual int id { get; set; }
        public virtual string country { get; set; }
    }
}
