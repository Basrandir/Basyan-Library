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
    public class User
    {
        /// <summary>
        /// Dictionary of all books in users library with associated page count
        /// </summary>
        private Dictionary<Book, int> _library = new Dictionary<Book, int>();

        public int Id { get; set; }
        public int Role { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public Dictionary<Book, int> Library
        {
            get { return _library; }
        }

        /// <summary>
        /// Basic constructor with all params
        /// </summary>
        /// <param name="id">Id of User from db</param>
        /// <param name="role">User role</param>
        /// <param name="name">Name of user</param>
        /// <param name="username">username of user</param>
        public User(int id, int role, string name, string username)
        {
            Id = id;
            Role = role;
            Name = name;
            Username = username;
        }
    }
}
