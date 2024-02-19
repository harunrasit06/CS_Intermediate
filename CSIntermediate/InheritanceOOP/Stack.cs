using System;
using System.Collections.Generic;
using System.Linq;

namespace CSIntermediate.InheritanceOOP
{
    public class Stack
    {
        private List<object> _StackList = new List<object>();
        //private readonly List<string> StackElements;
        //public string element { get; set; }
        

        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException(nameof(obj));
            else
            {
                _StackList.Add(obj);
                //element = (string)obj;
                //this.StackElements.Add(element);             
                Console.WriteLine("Element added.." + obj);
                                
            }

        }

        public object Pop()
        {
            if (_StackList.Count != 0)
            {
                
                Console.WriteLine("Last object is deleted, " + _StackList.LastOrDefault<object>());
                _StackList.RemoveAt(_StackList.Count - 1);
                //Console.WriteLine("Last object is deleted, " + StackElements.LastOrDefault<string>());
                //StackElements.RemoveAt(StackElements.Count-1);
                return _StackList.LastOrDefault<object>();

            }
            else
            {
                throw new InvalidOperationException(nameof(_StackList));
            }

        }

        public void Clear()
        {
            _StackList.Clear();
        }
    }
}
