using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace exercise
{
    internal class Stack
    {
        private readonly List<object> _list;
        private int _topItemIndex = -1;
        private object _popItem;

        public Stack()
        {
           _list = new List<object>();
           
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null is not valid");

            _list.Add(obj);
            _topItemIndex++;
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            _popItem = _list[_topItemIndex];
            _list.RemoveAt(_topItemIndex);
            _topItemIndex--;
            return _popItem;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
