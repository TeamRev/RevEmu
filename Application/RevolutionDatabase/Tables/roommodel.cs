using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class roommodel {
        public roommodel() { }
        public virtual string model { get; set; }
        public virtual int doorX { get; set; }
        public virtual int doorY { get; set; }
        public virtual double doorZ { get; set; }
        public virtual string heightmap { get; set; }
        public virtual int publicItems { get; set; }
        public virtual string clubOnly { get; set; }
    }
}
