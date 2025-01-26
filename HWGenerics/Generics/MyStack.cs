using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyStack<T>
    {
        private List<T> _list;
        public MyStack()
        {
            _list = new ();
        }
        public void Push(T value)
        {
            _list.Add(value);
        }
        public T Pop()
        {
            if(IsEmpty()) throw new EmptyStackException("Стэк пустой");
            T value = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return value;
        }
        public T Peek()
        {
            if (IsEmpty()) throw new EmptyStackException("Стэк пустой");
            return _list[_list.Count - 1];
        }
        public bool IsEmpty() => _list.Count < 1;  
    }
}
