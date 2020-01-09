using BLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BLService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetBooks" in both code and config file together.
    [ServiceContract]
    public interface IGetBooks
    {
        [OperationContract]
        List<Book> GetBooksByTitle(string title);

        [OperationContract]
        List<Book> GetBooksByAuthor(string authorName);
    }
}
