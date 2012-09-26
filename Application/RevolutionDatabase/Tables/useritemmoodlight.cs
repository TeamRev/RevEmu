using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class useritemmoodlight {
        public useritemmoodlight() { }
        public virtual int itemId { get; set; }
        public virtual string enabled { get; set; }
        public virtual int currentPreset { get; set; }
        public virtual string presetOne { get; set; }
        public virtual string presetTwo { get; set; }
        public virtual string presetThree { get; set; }
    }
}
