using BLLibrary.LibraryDataSetTableAdapters;
using System.Collections.Generic;
using static BLLibrary.LibraryDataSet;

/// <summary>
/// AUTHOR: Bassam Saeed
/// </summary>

namespace BLLibrary.DAL
{
    public class GenreDAO
    {
        /// <summary>
        /// Connects to the database BookGenre Table
        /// </summary>
        private BookGenreTableAdapter _genreAdapter;

        public GenreDAO()
        {
            _genreAdapter = new BookGenreTableAdapter();
        }

        /// <summary>
        /// Gets all Genres of the book that matches the bookId param
        /// </summary>
        /// <param name="bookId">Book ID that the user wants the genres of</param>
        /// <returns>List of genres that the bookId is of</returns>
        public List<Genre> GetBookGenres(int bookId)
        {
            List<Genre> bookGenres = new List<Genre>();

            foreach (BookGenreRow row in _genreAdapter.GetData().Rows)
            {
                if (row.BookId == bookId)
                    bookGenres.Add((Genre)row.GenreId);
            }

            return bookGenres;
        }

    }
}
