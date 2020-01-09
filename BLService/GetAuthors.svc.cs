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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetAuthors" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetAuthors.svc or GetAuthors.svc.cs at the Solution Explorer and start debugging.
    public class GetAuthors : IGetAuthors
    {
        /// <summary>
        /// Returns all authors that match param
        /// </summary>
        /// <param name="name">The author name to search</param>
        /// <returns></returns>
        public List<Author> GetAuthorsByName(string name)
        {
            AuthorDAO authorDAO = new AuthorDAO();

            List<Author> authors = authorDAO.getAuthors();

            return authors.FindAll(author => author.Name.Contains(name));
        }
    }
}
