// <copyright file="WeakReference.cs" company="Nito Programs">
//     Copyright (c) 2009 Nito Programs.
// </copyright>

using System;
using System.Runtime.InteropServices;

namespace Revolution.Util.External.Nito.Utility
{
    /// <summary>
    /// Represents a weak reference, which references an object while still allowing that object to be reclaimed by garbage collection.
    /// </summary>
    /// <remarks>
    /// <para>We define our own type, unrelated to <see cref="System.WeakReference"/> both to provide type safety and because <see cref="System.WeakReference"/> is an incorrect implementation (it does not implement <see cref="IDisposable"/>).</para>
    /// </remarks>
    /// <typeparam name="T">The type of object to reference.</typeparam>
    public sealed class WeakReference<T> : IDisposable where T : class
    {
        /// <summary>
        /// The contained <see cref="SafeGcHandle"/>.
        /// </summary>
        private readonly SafeGcHandle _safeHandle;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeakReference{T}"/> class, referencing the specified object.
        /// </summary>
        /// <param name="target">The object to track. May not be null.</param>
        public WeakReference(T target)
        {
            _safeHandle = new SafeGcHandle(target, GCHandleType.Weak);
        }

        /// <summary>
        /// Gets the referenced object. Will return null if the object has been garbage collected.
        /// </summary>
        public T Target
        {
            get { return _safeHandle.Handle.Target as T; }
        }

        /// <summary>
        /// Gets a value indicating whether the object is still alive (has not been garbage collected).
        /// </summary>
        public bool IsAlive
        {
            get { return _safeHandle.Handle.Target != null; }
        }

        /// <summary>
        /// Frees the weak reference.
        /// </summary>
        public void Dispose()
        {
            _safeHandle.Dispose();
        }

        public bool TryGetTarget(out T target)
        {
            target = Target;

            if (target == null)
                return false;
            return true;
        }
    }
}