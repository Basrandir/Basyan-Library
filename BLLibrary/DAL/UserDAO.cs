using BLLibrary.LibraryDataSetTableAdapters;
using System.Collections.Generic;
using System.Data;
using static BLLibrary.LibraryDataSet;

/// <summary>
/// AUTHOR: Bassam Saeed
/// </summary>

namespace BLLibrary.DAL
{
    public class UserDAO
    {
        /// <summary>
        /// Connects to the database User Table
        /// </summary>
        private UserTableAdapter _userAdapter;

        public UserDAO()
        {
            _userAdapter = new UserTableAdapter();
        }

        /// <summary>
        /// Goes through all rows in User table and creates a list of them
        /// </summary>
        /// <returns>Returns list of users</returns>
        public List<User> getUsers()
        {
            List<User> userList = new List<User>();

            foreach(UserRow row in _userAdapter.GetData().Rows)
            {
                userList.Add(
                    new User(row.UserId, row.Role, row.Name, row.Username)
                );
            }

            return userList;
        }

        /// <summary>
        /// Direct access to password column in User table, validates if password is correct
        /// </summary>
        /// <param name="user">the user logging in</param>
        /// <param name="password">the password they're providing</param>
        /// <returns>Returns true if password provided matches database password of user, else false</returns>
        public bool validateUser(User user, string password)
        {
            //DataRow[] rows = _userAdapter.GetData().Select($"name like '%{user.Name}%'");

            string dbPassword = (string)_userAdapter.GetPasswordByUsername(user.Username);

            if (dbPassword.Equals(password))
                return true;
            return false;
        }
    }
}
