using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.Editor
{
    public class GenericList<T> : ScriptableObject, IEnumerable<T>
    {
        [SerializeField]
        private List<T> _internalList;

        public static implicit operator List<T>(GenericList<T> list) => list._internalList;

        public GenericList()
        {
            _internalList = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Internal.GenericListEnum<T>(_internalList);
        }

        private IEnumerator GetEnumerator1()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator1();
        }
    }

    namespace Internal
    {
        public class GenericListEnum<T> : IEnumerator<T>
        {
            public List<T> _genericList;

            private int position = -1;

            public GenericListEnum(List<T> list)
            {
                _genericList = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _genericList.Count);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public T Current
            {
                get
                {
                    try
                    {
                        return _genericList[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            void IDisposable.Dispose() { }
        }

    }


}
