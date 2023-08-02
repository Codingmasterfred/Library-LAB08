using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB08
{
    public interface ILibrary : IReadOnlyCollection<Book>
    {
        /// <summary>
        /// Add a Book to the library.
        /// </summary>
       public void Add(string title,string author);

        /// <summary>
        /// Remove a Book from the library with the given title.
        /// </summary>
        /// <returns>The Book, or null if not found.</returns>
        Book Borrow(string title);

        /// <summary>
        /// Return a Book to the library.
        /// </summary>
        void Return(Book book);

    }
}
