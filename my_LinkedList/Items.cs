using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_LinkedList
{
    public class Items<T>
    {
        public Link_list<T> List = null;
        public T Value;
        public Items<T> Next = null;
        public Items<T> Before = null;
    }
}
