using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Subject
    {
        string name;
        Book[] books;
        
        public Subject(int numOfBooks)
        {
            books = new Book[numOfBooks];
        }
        public Subject() { }

        public Book[] Books { get { return books; } set { books = value; } }
        public string Name { get { return name; }set { name = value; } }


        public Book SearchBookByName(string bookName)
        {
            Book book = null;

                for (int i = 0; i < books.Count(); i++)
                {
                        if (books[i].Name == bookName)
                            book = Books[i];
                }
            
            return book;
        }
    }
}
