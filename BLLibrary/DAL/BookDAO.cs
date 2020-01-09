using BLLibrary.LibraryDataSetTableAdapters;
using System.Collections.Generic;
using static BLLibrary.LibraryDataSet;

/// <summary>
/// AUTHOR: Bassam Saeed
/// </summary>

namespace BLLibrary.DAL
{
    public class BookDAO
    {
        /// <summary>
        /// Connects to the Database Book Table
        /// </summary>
        private BookTableAdapter _bookAdapter;

        public BookDAO()
        {
            _bookAdapter = new BookTableAdapter();
        }

        /// <summary>
        /// Goes through all rows in Book table and creates a list of Books
        /// </summary>
        /// <param name="authors">List of all Authors</param>
        /// <returns>List of all Books</returns>
        public List<Book> getBooks(List<Author> authors)
        {
            List<Book> books = new List<Book>();

            foreach (BookRow row in _bookAdapter.GetData().Rows)
            {
                int bookId = row.BookId;

                Author bookAuthor = null;
                foreach(Author author in authors)
                {
                    if (author.Id == row.AuthorId)
                    {
                        bookAuthor = author;
                        break;
                    }
                }

                GenreDAO genreDAO = new GenreDAO();

                books.Add(
                    new Book(bookId, row.Title, bookAuthor, row.Year.Year, genreDAO.GetBookGenres(bookId))
                );
            }

            return books;
        }
    }
}
