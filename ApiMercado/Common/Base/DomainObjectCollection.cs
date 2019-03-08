using System;
using System.Collections;
using System.Collections.Generic;

namespace Common.Base
{

    public class DomainObjectCollection<T> :
           ICollection<T> where T : DomainObjectBase
    {

        #region Fields
        protected ArrayList _innerArray;
        protected bool _IsReadOnly;
        #endregion

        #region Constructors
        public DomainObjectCollection()
        {
            _innerArray = new ArrayList();
        }
        #endregion

        #region Properties

        public virtual T this[int index]
        {
            get
            {
                return (T)_innerArray[index];
            }
            set
            {
                _innerArray[index] = value;
            }
        }

        public virtual int Count => _innerArray.Count;

        public virtual bool IsReadOnly => _IsReadOnly;

        #endregion

        #region Methods
        public virtual void Add(T BusinessObject) => _innerArray.Add(BusinessObject);

        public virtual bool Remove(T BusinessObject)
        {
            bool result = false;

            //TODO: refatorar (código imperativo)
            for (int i = 0; i < _innerArray.Count; i++)
            {
                //store current index being checked
                T obj = (T)_innerArray[i];

                //compare the BusinessObjectBase UniqueId property
                if (obj.UniqueId == BusinessObject.UniqueId)
                {
                    //remove item from inner ArrayList at index i
                    _innerArray.RemoveAt(i);
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool Contains(T BusinessObject)
        {
            foreach (T obj in _innerArray)
            {
                if (obj.UniqueId == BusinessObject.UniqueId)
                {
                    return true;
                }
            }
            return false;
        }

        public virtual void CopyTo(T[] BusinessObjectArray, int index)
        {
            throw new Exception();
        }

        public virtual void Clear()
        {
            _innerArray.Clear();
        }

        // Returns custom generic enumerator for this BusinessObjectCollection
        public virtual IEnumerator<T> GetEnumerator()
        {
            //return a custom enumerator object instantiated
            //to use this BusinessObjectCollection 
            return new DomainObjectEnumerator<T>(this);
        }

        // Explicit non-generic interface implementation for IEnumerable
        // extended and required by ICollection (implemented by ICollection<T>)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DomainObjectEnumerator<T>(this);
        }
        #endregion
    }
}
