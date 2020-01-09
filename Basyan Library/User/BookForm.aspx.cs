using BLLibrary;
using BLLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basyan_Library
{
    public partial class BookForm : System.Web.UI.Page
    {
        private Book _book;
        protected void Page_Load(object sender, EventArgs e)
        {
            string encodedTitle = Request.QueryString["title"];
            byte[] bTitle = HttpServerUtility.UrlTokenDecode(encodedTitle);
            string title = HttpUtility.UrlDecode(Encoding.UTF8.GetString(bTitle));

            List<Book> books = (List<Book>)Session["bookList"];
            foreach (Book book in books)
            {
                if (book.Title.Equals(title))
                {
                    _book = book;
                    LblShowAuthor.Text = book.Author.Name;
                    LblShowGenre.Text = string.Join(", ", book.Genres.ToArray());
                    LblShowTitle.Text = book.Title;
                    LblShowYear.Text = book.Year.ToString();
                }
            }
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            User currentUser = null;

            foreach (User user in (List<User>)Session["userList"])
                if (user.Username.Equals(Context.User.Identity.Name))
                {
                    currentUser = user;
                    break;
                }

            bool exists = false;
            foreach(KeyValuePair<Book, int> keyValuePair in currentUser.Library)
            {
                if (keyValuePair.Key.Id == _book.Id)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
                lblAddBook.Text = "Already exists your in Library";
            else
            {
                currentUser.Library.Add(_book, 0);

                LibraryDAO libraryDAO = new LibraryDAO();

                libraryDAO.addLibrary(currentUser, _book, 0);

                lblAddBook.Text = "Book successfully added";
            }
        }
    }
}