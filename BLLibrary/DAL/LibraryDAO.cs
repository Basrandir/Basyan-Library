using BLLibrary.LibraryDataSetTableAdapters;
using System.Collections.Generic;
using static BLLibrary.LibraryDataSet;

/// <summary>
/// AUTHOR: Bassam Saeed
/// </summary>

namespace BLLibrary.DAL
{
    public class LibraryDAO
    {
        /// <summary>
        /// Connects to the database Library Table
        /// </summary>
        private LibraryTableAdapter _libAdapter;

        public LibraryDAO()
        {
            _libAdapter = new LibraryTableAdapter();
        }

        /// <summary>
        /// Fills all Users with the books they have in their personal library with associated page count
        /// </summary>
        /// <param name="users">List of all users</param>
        /// <param name="books">List of all books</param>
        public void fillLibrary(List<User> users, List<Book> books)
        {
            // UserId   BookId  Pagecount
            // 1        1       4
            // 1        2       53
            // 2        1       323

            foreach (LibraryRow row in _libAdapter.GetData().Rows)
            {
                foreach (User user in users)
                {
                    if (user.Id == row.UserId)
                    {
                        foreach (Book book in books)
                        {
                            if (book.Id == row.BookId)
                            {
                                user.Library.Add(book, row.PageCount);
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adds new book to user library
        /// </summary>
        /// <param name="user">User that's having a new book added to their library</param>
        /// <param name="book">The book that's being added</param>
        /// <param name="pageCount">The pagecount (default 0)</param>
        public void addLibrary(User user, Book book, int pageCount)
        {
            _libAdapter.Insert(user.Id, book.Id, pageCount);
        }
    }
}
