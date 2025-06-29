using GenericLinkedList;
using GenericLinkedList.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class MyItem<T> : IMyItem<T>
    {
        public T Content { get; set; }
        public IMyItem<T> NextItem {  get; set; }
        public MyItem(T content, MyItem<T> nextItem)
        {
            Content = content;
            NextItem = nextItem;
        }
    }
}
