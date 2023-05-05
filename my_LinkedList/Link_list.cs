using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace my_LinkedList
{
    public interface IEnumerable<T>
    {
         IEnumerator<T> GetEnumerator();
    }
    public interface IComparable<T>
    {
        int CompareTo(Link_list<T> obj);

    }
    public interface IClonable<T>
    {
        Link_list<T> Clone();
    }
    public interface ICollectionn<T>
    {
        void CopyTo(T[] array, int arrayIndex);
        void Add(T item);
        void AddFirst(T symbol);
        T First_Value();
        void RemoveFirst();
        void AddLast(T symbol);
        void RemoveLast();
        T Last_Value();
        bool Contains(T symbol);
        void AddAfter(Items<T> current, T symbol);
        void AddBefore(Items<T> current, T symbol);
    }
    public class Link_list<T> : IComparable<T>, IEnumerable<T>, IClonable<T>, ICollectionn<T>
    {
        private static Items<T> head;       
        private static Items<T> tail;
        public int Count = 0;
        public Link_list(T[] words)
        {
            foreach (T sign in words)
            {
                this.append(sign);
            }
        }
        public Link_list()
        {

        }
        private void append(T st)
        {
            if (Count == 0)
            {
                head = new Items<T>();
                tail = new Items<T>();
                head.List = this;
                tail.List = this;
                head.Value = st;
                tail.Value = st;
                Count = 1;
            }
            else
            {
                if (Count == 1)
                {
                    Items<T> next = new Items<T>();
                    next.List = this;
                    next.Value = st;
                    head.Next = next;
                    next.Before = head;
                    tail = next;
                    Count += 1;
                }
                else
                {
                    Items<T> next = new Items<T>();
                    next.List = this;
                    next.Value = st;
                    tail.Next = next;
                    next.Before = tail;
                    tail = next;
                    Count += 1;
                }
            }
        }
        public void AddLast(T symbol)
        {
            append(symbol);
        }
        public void AddLast(Items<T> tmp)
        {
            append(tmp.Value);
        }

        public Items<T> FindLast(T value)
        {
            Items<T> temp = tail;
            while (temp.Before != null)
            {
                if (Equals(temp.Value, value))
                {
                    return temp;
                }
                temp = temp.Before;
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder("");
            foreach (T symbol in this)
            {
                output.Append(symbol + " ");
            }
            return output.ToString();
        }
        public void AddFirst(T symbol)
        {
            Items<T> new_head = new Items<T>();
            new_head.List = this;

            new_head.Value = symbol;
            new_head.Next = head;
            head.Before = new_head;
            head = new_head;
            Count += 1;
        }
        public void AddFirst(Items<T> tmp)
        {
            T symbol = tmp.Value;
            Items<T> new_head = new Items<T>();
            new_head.List = this;
            new_head.Value = symbol;
            new_head.Next = head;
            head.Before = new_head;
            head = new_head;
            Count += 1;
        }


        public T First_Value()
        {
            return head.Value;
        }
        public Items<T> First() {
            return head;
        }
        public void RemoveFirst()
        {
            head.List = null;
            head = head.Next;
            head.Before = null;
            Count -= 1;
        }
        public void RemoveLast()
        {
            if (Count == 1)
            {
                tail.List = null;
                Clear();
            }
            else
            {
                tail.List = null;
                Items<T> prev = tail.Before;
                prev.Next = null;
                tail = prev;
                Count -= 1;
            }
        }
        public T Last_Value()
        {
            return tail.Value;
        }
        public Items<T> Last() { return tail; }


        public bool Contains(T symbol)
        {
            if (Find(symbol) != null)
            { return true; }
            else { return false; }
        }
        public Items<T> Find(T symbol)
        {
            Items<T> temp = head;
            while (temp != null)
            {
                if (Equals(temp.Value, symbol))
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public Items<T> Find(Items<T> symbol)
        {
            var comparer = Comparer<T>.Default;
            Items<T> temp = head;
            while (temp != null)
            {
                if (Equals(temp.Value, symbol.Value))
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public Items<T> FindLast(Items<T> symbol)
        {
            Items<T> temp = tail;
            while (temp != null)
            {
                if (Equals(temp.Value, symbol.Value))
                {
                    return temp;
                }
                temp = temp.Before;
            }
            return null;
        }
        public void AddAfter(Items<T> current, T symbol)
        {
            Items<T> temp = FindLast(current);
            if (temp != null)
            {
                if (Equals(temp.Value, head.Value))
                {
                    AddLast(symbol);

                }
                else
                {
                    Items<T> next = current.Next;
                    Items<T> curr = new Items<T>();
                    curr.List = this;
                    curr.Value = symbol;
                    current.Next = curr;
                    curr.Before = current;
                    curr.Next = next;
                    next.Before = curr;
                }
                Count += 1;
            }
        }
        public void AddAfter(Items<T> current, Items<T> symbol)
        {
            Items<T> temp = Find(current.Value);
            if (temp != null)
            {
                if (Equals(current.Value, head.Value))
                {
                    AddLast(symbol);
                }
                else
                {
                    Items<T> next = current.Next;
                    Items<T> curr = symbol;
                    curr.List = this;
                    current.Next = curr;
                    curr.Before = current;                  
                    curr.Next = next;
                    next.Before = curr;
                }
                Count += 1;
            }
        }

        public void AddBefore(Items<T> current, T symbol)
        {
            Items<T> temp = Find(current.Value);
            if (temp != null)
            {

                Items<T> previous = temp.Before;
                Items<T> curr = new Items<T>();
                curr.List = this;

                curr.Value = symbol;
                temp.Before = curr;
                curr.Before = previous;
                curr.Next = temp;
                previous.Next = curr;
                Count += 1;
            }
        }
        public void AddBefore(Items<T> current, Items<T> symbol)
        {
            Items<T> temp = Find(current.Value);
            if (temp != null)
            {
                if (Equals(current.Value, tail.Value))
                {
                    AddLast(symbol);
                }
                else
                {
                    Items<T> previous = temp.Before;
                    Items<T> curr = symbol;
                    curr.List = this;
                    temp.Before = curr;
                    curr.Before = previous;
                    curr.Next = temp;
                    previous.Next = curr;
                }
                Count += 1;
            }
        }
        public void Clear()
        {
            head.List = null;
            tail.List = null;
            head = null;
            tail = null;

            Count = 0;
        }
        ///для Inumerable
        public IEnumerator<T> GetEnumerator()
        {
            Items<T> temp = head;
            while (temp != null)
            {
                yield return temp.Value; ///не понимаю как
                temp = temp.Next;
            }
        }
        ///для CompareTo
        public int CompareTo(Link_list<T> obj)
        {
            return this.Count.CompareTo(obj.Count);
        }
        /// для IClonable
        public Link_list<T> Clone()
        {
            Link_list<T> new_list = new Link_list<T>();
            foreach (T symbol in this)
            {
                new_list.append(symbol);
            }
            return new_list;
        }
        ///сортировка
        public int CompareTo(T x, T y) ///where T: IComparable<T>
        {
            var comparer = Comparer<T>.Default;
            return comparer.Compare(x, y);
        }
        public void Sort()
        {
            var comparer = Comparer<T>.Default;
            Items<T> temp = head;
            while (temp.Next != null)
            {
                Items<T> current = head;
                while (current.Next != null)
                {
                    if (comparer.Compare(current.Value, current.Next.Value) > 0)
                    {
                        T follow = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = follow;
                    }
                    current = current.Next;
                }
                temp = temp.Next;
            }
        }
        public void Remove(T symbol)
        {
            Items<T> delete = Find(symbol);
            Items<T> follow = delete.Next;
            Items<T> last = delete.Before;
            if (last != null)
            {
                last.Next = follow;
            }
            else
            {
                RemoveFirst();
            }
            if (follow != null)
            {
                follow.Before = last;
            }
            else
            {
                RemoveLast();
            }
        }
        public void Remove(Items<T> symbol)
        {
            Items<T> delete = Find(symbol);
            Items<T> follow = delete.Next;
            Items<T> last = delete.Before;
            if (last != null)
            {
                last.Next = follow;
            }
            else
            {
                RemoveFirst();
            }
            if (follow != null)
            {
                follow.Before = last;
            }
            else
            {
                RemoveLast();
            }
        }

        public void Add(T item)
        {
            Items<T> tmp = new Items<T>();
            tmp.Value = item;
            Items<T> prev = tail.Before;
            prev.Next = tmp;
            tmp.Before = prev;
            tail = tmp;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int ind = 0;
            int k = 0;
            foreach (T word in this)
            {
                if (ind>= arrayIndex)
                {
                    array[k] = word;
                    k += 1;
                }
                ind += 1;
            }
        }
    }
}