using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class catalogpage {
        public catalogpage() { }
        public virtual int id { get; set; }
        public virtual int parentId { get; set; }
        public virtual int orderId { get; set; }
        public virtual string name { get; set; }
        public virtual int accessRank { get; set; }
        public virtual int iconImage { get; set; }
        public virtual int iconColor { get; set; }
        public virtual int layout { get; set; }
        public virtual string imgHeadline { get; set; }
        public virtual string imgTeaser { get; set; }
        public virtual string special { get; set; }
        public virtual string textOne { get; set; }
        public virtual string textTwo { get; set; }
        public virtual string textDetails { get; set; }
        public virtual string textTeaser { get; set; }
    }
}
