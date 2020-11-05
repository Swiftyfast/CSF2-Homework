using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {

        //field

        //props
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }


        //ctor
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book() { }

        //methods
        public override string ToString()
        {
            return string.Format(Title + ", a book by " + Author);
                //Ask about string.Format()
        }

    }
}
