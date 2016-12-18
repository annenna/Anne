using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    public class BaseList<T>: BaseClass, IList<T>   // minu baasklass on ka ilist. 
    {
        private readonly List<T> list = new List<T>();// Praegu on new List, see täh et mälu on eraldatud. Null on siis kui mälu pole.

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count => list.Count; //sama mis:  get { return list.Count;

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            list.Add(item);
            DoOnChanged();
        }//lisab listi

        public void Clear()
        {
            throw new NotImplementedException();
        }// teeb listi tühjaks

        public bool Contains(T item)
        {
            return list.Contains(item);
        }// vaatab kas element on juba kollektsioonis. DoOnChanged ole vaja kuna listi ei muudeta. Vastused saavad olla kas true või 

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }// kopeerib kuhugi listi

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
