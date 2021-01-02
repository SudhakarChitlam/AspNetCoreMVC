using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string author, string title)
        {
            return DataSource().Where(x => x.Author.Contains(author) || x.Title.Contains(title)).ToList();
        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Author="MVC" , Title="Sudh"},
                new BookModel(){Id=2, Author="Dotnet" , Title="Ramesh"},
                new BookModel(){Id=3, Author="Core" , Title="Suresh"},
                new BookModel(){Id=4, Author="SQL" , Title="Naresh"}
            };
        }

    }
}
