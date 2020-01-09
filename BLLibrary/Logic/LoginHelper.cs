using BLLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Bassam Saeed
/// </summary>

namespace BLLibrary.Logic
{
    /// <summary>
    /// Static class that aids with login
    /// </summary>
    public static class LoginHelper
    {
        /// <summary>
        /// references the DAO and the resulting collection of user objects
        /// </summary>
        private static readonly UserDAO _userDAO = new UserDAO();
        private static readonly List<User> _users = _userDAO.getUsers();

        /// <summary>
        /// Validates that user is authentic in the db
        /// </summary>
        /// <param name="username">username to be validated</param>
        /// <param name="password">password of user</param>
        /// <returns></returns>
        public static bool IsAuthentic(string username, string password)
        {
            List<User> users = _userDAO.getUsers();

            foreach(User user in _users)
            {
                if (user.Username.Equals(username))
                {
                    if (_userDAO.validateUser(user, password))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if newly logged in user is a regular user or an admin
        /// </summary>
        /// <param name="username">username of user</param>
        /// <returns></returns>
        public static string GetUserRole(string username)
        {
            int role = 0;
            foreach(User user in _users)
            {
                if (user.Username.Equals(username))
                    role = user.Role;
            }

            switch (role) {
                case 1:
                    return "admin";
                case 2:
                    return "user";
                default:
                    return null;
            }
        }
    }
}
