# Library-LAB08
The "Phil's Lending Library" project is a C# console application that simulates a lending library system. The goal is to create classes and interfaces to manage a collection of books, allow users to borrow and return books, and provide a user-friendly interface to interact with the library.

Key Components:

Book Class: This class represents a book and holds properties like Title and Author. It provides a simple data structure to store book information.

ILibrary Interface: This interface defines the contract for a Library class. The Library class should implement this interface and provide methods to add books to the library, borrow books, return books, and search for books by their titles.

Library Class: The Library class implements the ILibrary interface. It internally uses a private Dictionary<string, Book> to store books, where the key is the book's title. The Library class provides methods to add books to the collection, borrow books from the library (removing them from the collection), return books (adding them back to the collection), and search for books based on their titles.

IBag<T> Interface: This generic interface defines the contract for a Backpack class, allowing it to hold any type of item (not just books). The Backpack class should implement this interface.

Backpack Class: The Backpack class is a generic class that implements the IBag<T> interface. It uses a private List<T> to store items (in this case, borrowed books). The Backpack class provides methods to add items to the backpack and remove items based on their index.

DSA LinkedList: The project also includes an updated version of the DSA LinkedList, which is now made generic (class LinkedList<T>) and implements IEnumerable<T>.

Console User Interface: The application has a user interface that interacts with the user through the console. It provides various options like viewing all books, adding a book, borrowing a book, returning a book, viewing the book bag, and exiting the application. The user can navigate through these options using the console input.
