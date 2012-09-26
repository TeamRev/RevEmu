using Iesi.Collections.Generic; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace RevolutionDatabase.Tables {
    
    public class room {
        public room() { }
        public virtual int id { get; set; }
        public virtual int category { get; set; }
        public virtual int ownerId { get; set; }
        public virtual string name { get; set; }
        public virtual string description { get; set; }
        public virtual string model { get; set; }
        public virtual string state { get; set; }
        public virtual string password { get; set; }
        public virtual string wallpaper { get; set; }
        public virtual int wallsize { get; set; }
        public virtual string floor { get; set; }
        public virtual int floorsize { get; set; }
        public virtual int score { get; set; }
        public virtual string tags { get; set; }
        public virtual int iconBg { get; set; }
        public virtual int iconFg { get; set; }
        public virtual string iconItems { get; set; }
    }
}
