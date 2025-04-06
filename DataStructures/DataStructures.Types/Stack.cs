
using System.Collections;

namespace DataStructures.Types
{
    public class Stack<T> : IEnumerable<T>
    {

        private readonly List<T> array = [];

        public void Push(T item)
        {
            array.Add(item);
        }

        public T Pop()
        {
            if (array.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var item = array[array.Count - 1];

            array.RemoveAt(array.Count - 1);

            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach( var item in array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
