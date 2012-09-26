using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace RevolutionDatabase.Tables {
    
    
    public class botspeechMap : ClassMap<botspeech> {
        
        public botspeechMap() {
			Table("botspeech");
			LazyLoad();
			CompositeId().KeyProperty(x => x.id, "id").KeyProperty(x => x.botId, "bot_id");
			Map(x => x.speech).Column("speech").Not.Nullable();
			Map(x => x.shout).Column("shout").Not.Nullable();
        }
    }
}
