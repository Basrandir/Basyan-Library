using BLLibrary;
using BLLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BLService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetBooks" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetBooks.svc or GetBooks.svc.cs at the Solution Explorer and start debugging.
    public class GetBooks : IGetBooks
    {
        /// <summary>
        /// Returns all books that match param
        /// </summary>
        /// <param name="title">Book title to search by</param>
        /// <returns></returns>
        public List<Book> GetBooksByTitle(string title)
        {
            BookDAO booksDAO = new BookDAO();
            AuthorDAO authorDAO = new AuthorDAO();

            List<Book> books = booksDAO.getBooks(authorDAO.getAuthors());

            return books.FindAll(book => book.Title.Contains(title));
        }

        /// <summary>
        /// Returns all books that match param
        /// </summary>
        /// <param name="authorName">Author name to search books by</param>
        /// <returns></returns>
        public List<Book> GetBooksByAuthor(string authorName)
        {
            BookDAO booksDAO = new BookDAO();
            AuthorDAO authorDAO = new AuthorDAO();

            List<Book> books = booksDAO.getBooks(authorDAO.getAuthors());

            return books.FindAll(book => book.Author.Name.Equals(authorName));
        }

    }
}
