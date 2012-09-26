using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class item {
        public item() { }
        public virtual int id { get; set; }
        public virtual string itemName { get; set; }
        public virtual string name { get; set; }
        public virtual string type { get; set; }
        public virtual int width { get; set; }
        public virtual int length { get; set; }
        public virtual double height { get; set; }
        public virtual int sprite { get; set; }
        public virtual string stackable { get; set; }
        public virtual string sitable { get; set; }
        public virtual string walkable { get; set; }
        public virtual string recyclable { get; set; }
        public virtual string tradeable { get; set; }
        public virtual string sellable { get; set; }
        public virtual string giftable { get; set; }
        public virtual string inventoryStackable { get; set; }
        public virtual int behaviour { get; set; }
        public virtual int behaviourCount { get; set; }
        public virtual string vending { get; set; }
    }
}
