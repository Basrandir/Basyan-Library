using BLLibrary.LibraryDataSetTableAdapters;
using System.Collections.Generic;
using static BLLibrary.LibraryDataSet;

/// <summary>
/// AUTHOR: Bassam Saeed
/// </summary>

namespace BLLibrary.DAL
{
    /// <summary>
    /// Interacts with Author table
    /// </summary>
    public class AuthorDAO
    {
        /// <summary>
        /// Connects to the database Author Table
        /// </summary>
        private AuthorTableAdapter _authorAdapter;

        /// <summary>
        /// Creates adapter from dataset
        /// </summary>
        public AuthorDAO()
        {
            _authorAdapter = new AuthorTableAdapter();
        }

        /// <summary>
        /// Goes through all rows in Author table and creates a list of authors
        /// </summary>
        /// <returns>Returns list of authors</returns>
        public List<Author> getAuthors()
        {
            List<Author> authors = new List<Author>();

            foreach(AuthorRow row in _authorAdapter.GetData().Rows)
            {
                authors.Add(
                    new Author(row.AuthorId, row.Name, row.DOB, row.Country)
                );
            }

            return authors;
        }
    }
}
