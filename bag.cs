using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB08
{
    public class Bag : IBag<Book>
    {
        private List<Book> Storage;
        public Bag()
        {
            Storage = new List<Book>();
        }

        public void ViewAll()
        {
            Console.WriteLine("Here are your Books!");
            for (int i = 0; i < Storage.Count; i++)
            {
                string bookTitle = Storage[i].Title;
                Console.WriteLine($"[{i}] {bookTitle}");
            }
        }
        public void Pack(Book item)
        {
            Storage.Add(item);

        }
        public Book Unpack(int index)
        {
            return Storage[index];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return Storage.GetEnumerator();
        }


    }

}
