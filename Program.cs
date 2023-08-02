namespace Library_LAB08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ;
            Console.WriteLine("Hello welcome to my Library");

            Library myLibrary = new Library();
            Bag newBag = new Bag();

            while (true)
            {
                Console.WriteLine("Here are your options:");
                Console.WriteLine("Add a Book [1]");
                Console.WriteLine("Borrow a book [2]");
                Console.WriteLine("Return a book [3]");
                Console.WriteLine("Search For book [4]");
                Console.WriteLine("View all books [5]");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    myLibrary.ViewAllBooks();
                }
                else if (choice == "1")
                {

                    Console.WriteLine("Please enter the Title of the book");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Please enter the Author of the book");
                    string bookAuthor = Console.ReadLine();

                    myLibrary.Add(bookTitle, bookAuthor);
                     
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Name the title of the book you will like to borrow ");
                    string Title = Console.ReadLine();
                   Book book = myLibrary.Borrow(Title);
                    newBag.Pack(book);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Search for a book by its title");
                     string userInput = Console.ReadLine();
                    myLibrary.Search(userInput);
                }
                else if(choice == "3")
                {
                    newBag.ViewAll();
                    Console.WriteLine("Return A Book by its number ");
                    string userInput = Console.ReadLine();
                    int userInputAsNumber = Convert.ToInt32(userInput);
                    Book Unpack = newBag.Unpack(userInputAsNumber);
                    myLibrary.Add(Unpack.Title, Unpack.Author);

                }
               
            }
        }
    }
    }