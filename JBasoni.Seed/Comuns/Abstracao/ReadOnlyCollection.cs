using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Seed.Comuns.Abstracao
{
    public class ReadOnlyCollection<T> : ICollection<T>
    {
        protected ICollection<T> ListaInterna;

        #region ' Constructor '

        public ReadOnlyCollection()
        {
            this.ListaInterna = new List<T>();
        }

        public ReadOnlyCollection(List<T> lista)
        {
            this.ListaInterna = new List<T>();
            lista.ForEach(ListaInterna.Add);
        }

        #endregion

        /// <summary>
        ///     Adds an item to the internal <c>System.Collections.Generic.List&lt;T&gt;</c>.
        /// </summary>
        /// <param name="item">The object to add.</param>
        public void AddItem(T item)
        {
            ListaInterna.Add(item);
        }

        /// <summary>
        ///     Removes the first occurrence of a specific object from the internal
        ///     <c>System.Collections.Generic.List&lt;T&gt;</c>
        /// </summary>
        /// <param name="item">
        ///     The object to remove.
        /// </param>
        /// <returns>
        ///     true if item was successfully removed from the internal list; otherwise, false.
        ///     This method also returns false if item is not found in the internal list.
        /// </returns>
        /// <exception cref="NotSupportedException">
        ///     The <see cref="ListaInterna"/> is read-only.
        /// </exception>
        public bool RemoveItem(T item)
        {
            return ListaInterna.Remove(item);
        }

        public void Clear()
        {
            ListaInterna.Clear();
        }

        #region ' ICollection<T> '

        void ICollection<T>.Add(T item)
        {
            ListaInterna.Add(item);
        }

        void ICollection<T>.Clear()
        {
            ListaInterna.Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            return ListaInterna.Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            ListaInterna.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return ListaInterna.Count; }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { return ListaInterna.IsReadOnly; }
        }

        bool ICollection<T>.Remove(T item)
        {
            return ListaInterna.Remove(item);
        }

        [DebuggerStepThrough]
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => ListaInterna.GetEnumerator();

        [DebuggerStepThrough]
        IEnumerator IEnumerable.GetEnumerator() => ListaInterna.GetEnumerator();

        #endregion

        public static implicit operator ReadOnlyCollection<T>(List<T> source)
        {
            return new ReadOnlyCollection<T>() { ListaInterna = source };
        }
    }
}
