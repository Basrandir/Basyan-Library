using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Yan Hui Ma
/// </summary>
/// 
namespace BLLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Year { get; set; }
        public List<Genre> Genres { get; set; }

        /// <summary>
        /// Basic constructor for all params
        /// </summary>
        /// <param name="id">Book Id from db</param>
        /// <param name="title">Title of Book</param>
        /// <param name="author">Author of Book</param>
        /// <param name="year">Year of Publication</param>
        /// <param name="genres">List of genres the book is part of</param>
        public Book(int id, string title, Author author, int year, List<Genre> genres)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Genres = genres;
        }
    }
}
