using System.Collections;
using System.Collections.Generic;

namespace Common.Base
{

    public class DomainObjectEnumerator<T> : IEnumerator<T> where T : DomainObjectBase
    {
        #region Fields

        protected DomainObjectCollection<T> _collection;
        protected int index;
        protected T _current;

        #endregion

        #region Constructors
        public DomainObjectEnumerator() { }


        public DomainObjectEnumerator(DomainObjectCollection<T> collection)
        {
            _collection = collection;
            index = -1;
            _current = default(T);
        }

        #endregion

        #region Properties

        public virtual T Current => _current;

        object IEnumerator.Current => _current;

        #endregion

        #region Methods

        public virtual void Dispose()
        {
            _collection = null;
            _current = default(T);
            index = -1;
        }

        public virtual bool MoveNext()
        {
            if (++index >= _collection.Count)
                return false;
            else
                _current = _collection[index];


            return true;
        }

        public virtual void Reset()
        {
            _current = default(T);
            index = -1;
        }

        #endregion
    }
}
