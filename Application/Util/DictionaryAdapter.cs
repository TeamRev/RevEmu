using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revolution.Application.Util
{
    class DictionaryAdapter<TKey, TValue> : IDisposable
    {
        /// <summary>
        /// Directory we work on.
        /// </summary>
        public IDictionary<TKey, TValue> Dictionary { get; private set; }

        /// <summary>
        /// Start the streaming.
        /// </summary>
        /// <param name="Dictionary"></param>
        public DictionaryAdapter(IDictionary<TKey, TValue> Dictionary)
        {
            this.Dictionary = Dictionary;
        }

        /// <summary>
        /// Tries to return the right value.
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public TValue TryPopValue(TKey Key)
        {
            TValue Output;
            Dictionary.TryGetValue(Key, out Output);
            return Output;
        }

        /// <summary>
        /// Tries to return the right Key.
        /// </summary>
        /// <returns></returns>
        public TKey TryPopKey(TValue Value)
        {
            foreach (var kvp in Dictionary)
            {
                if (kvp.Value.Equals(Value))
                {
                    return kvp.Key;
                }
            }

            return default(TKey);
        }

        /// <summary>
        /// End of stream
        /// </summary>
        public void Dispose()
        {
            Dictionary = null;
        }
    }
}
