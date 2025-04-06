using System.Collections;

namespace DataStructures.Types
{
    namespace Queue
    {
        public class Queue<T> : IEnumerable<T>
        {
            public bool IsEmpty { get { return array.Count == 0; } }
            public int Count { get { return array.Count; } }

            private readonly List<T> array = [];

            public void Enqueue(T item)
            {
                array.Add(item);

            }

            public T Dequeue()
            {
                if (array.Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                var item = array[0];

                array.RemoveAt(0);

                return item;

            }

            public void Clear()
            {
                array.Clear();

            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (var item in array)
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
}
