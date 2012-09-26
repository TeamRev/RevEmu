#region GPLv3

// 
// Copyright (C) 2012  Chris Chenery
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General internal License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General internal License for more details.
// 
// You should have received a copy of the GNU General internal License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 

#endregion

#region Usings
using System.Collections.Generic;
#endregion


namespace Revolution.Util.External.Nito.Cache
{
    public delegate TValue InstanceGenerator<in TKey, out TValue>(TKey index);

    public class WeakCache<TKey, TValue> where TValue : class
    {
        #region Fields
        #region Field: _instanceGenerator
        private readonly InstanceGenerator<TKey, TValue> _instanceGenerator;
        #endregion
        #region Field: _cache
        /// <summary>
        ///   Stores the cached instances.
        /// </summary>
        private readonly Dictionary<TKey, Nito.Utility.WeakReference<TValue>> _cache = new Dictionary<TKey, Nito.Utility.WeakReference<TValue>>();

        public WeakCache(InstanceGenerator<TKey, TValue> instanceGenerator)
        {
            _instanceGenerator = instanceGenerator;
        }

        #endregion
        #endregion

        #region Indexers
        #region Indexer: TKey
        public TValue this[TKey index]
        {
            get
            {
                TValue instance;
                lock (this)
                {
                    // Is this Habbo already cached?
                    if (_cache.ContainsKey(index))
                    {
                        // Has the cached Habbo been collected and removed from memory?
                        if (_cache[index].TryGetTarget(out instance))
                            // No, return the cached copy.
                            return instance;

                        // Yes, remove it. We'll have to recache it.
                        _cache.Remove(index);
                    }

                    // Create a new instance using the implemented ConstructInstance method.
                    instance = _instanceGenerator.Invoke(index);

                    // And cache it.
                    _cache.Add(index, new Nito.Utility.WeakReference<TValue>(instance));
                }

                // Return the newly cached instance.
                return instance;
            }
            set
            {
                lock (this)
                {
                    if (_cache.ContainsKey(index))
                        return;
                    _cache.Add(index, new Nito.Utility.WeakReference<TValue>(value));
                }
            }
        }
        #endregion
        #endregion

        #region Methods
        #region Method: CleanUp
        /// <summary>
        ///   Remove any collected Habbos from the cache.
        /// </summary>
        public void CleanUp()
        {
            // The WeakReference<T> class in .NET 4.0 appears to be unfinished.
            // There appears to be missing members and the documentation is hidden away.

            // Because of this I have to store the value somewhere... so I put it here.
            lock (this)
            {
                // Initilise a List<TKey> to hold the keys of the cache entries to remove.
                // An initial size of _cache.Count will remove all need for resizing at the expence of some short lived RAM usage.
                List<TKey> keysToRemove = new List<TKey>(_cache.Count);
                foreach (KeyValuePair<TKey, Nito.Utility.WeakReference<TValue>> cacheEntry in _cache)
                {
                    TValue targetValue;
                    if (!cacheEntry.Value.TryGetTarget(out targetValue))
                        keysToRemove.Add(cacheEntry.Key);
                }
                foreach (TKey key in keysToRemove)
                {
                    _cache.Remove(key);
                }
            }
        }
        #endregion
        #endregion
    }
}
