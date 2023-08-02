using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB08
{
     internal class Library: ILibrary
    {
        
        private Dictionary<string, Book> Storage;


        public Library()
        {
            Storage = new Dictionary<string, Book>();   
            Book book1 = new Book("To Kill A MockingBird", "SomeGuy");
            Book book2 = new Book("Americana", "Shemamonda");
            Book book3 = new Book("Berserk", "Kentaro Miura");
            Storage.Add(book1.Title, book1);
            Storage.Add(book2.Title, book2);
            Storage.Add(book3.Title, book3);
        }

        public int Count => throw new NotImplementedException();

        public void Add(string title, string author)
        {
            Book newBook = new Book(title, $"{author} ");
            Storage.Add(newBook.Title, newBook);

        }

        public Book Borrow(string title)
        {
            if (Storage.TryGetValue(title, out Book book))
            {
                Storage.Remove(title);
                return book;
            }
            return null;

            throw new NotImplementedException();
        }


        public IEnumerator<Book> GetEnumerator()
        {
            return Storage.Values.GetEnumerator();
        }

        public void Return(Book book)
        {
            if (book != null && !Storage.ContainsKey(book.Title))
            {
                Storage.Add(book.Title, book);
            }
        }

        public Book Search(string title)
        {
            bool storageTitle = Storage.ContainsKey(title);
            if (storageTitle == true)
            {
                return Storage[title];

            }
            return null;
        }

        public void ViewAllBooks()
        {
            var keys = Storage.Keys;
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                Console.WriteLine(key);

            }

        }
    

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
