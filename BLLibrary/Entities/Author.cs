using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Yan Hui Ma
/// </summary>

namespace BLLibrary
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Country { get; set; }

        /// <summary>
        /// Basic constructor for all params
        /// </summary>
        /// <param name="id">Unique ID from DB</param>
        /// <param name="name">Name of author</param>
        /// <param name="dob">Date of Birth of author</param>
        /// <param name="country">Country of origin of author</param>
        public Author(int id, string name, DateTime dob, string country)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Country = country;
        }
    }
}
