using BLLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basyan_Library
{
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string encodedTitle = Request.QueryString["title"];
            string encodedAuthorName = Request.QueryString["author"];
            string encodedGenre = Request.QueryString["genre"];

            byte[] bTitle = HttpServerUtility.UrlTokenDecode(encodedTitle);
            byte[] bAuthorName = HttpServerUtility.UrlTokenDecode(encodedAuthorName);
            byte[] bGenre = HttpServerUtility.UrlTokenDecode(encodedGenre);

            string title = HttpUtility.UrlDecode(Encoding.UTF8.GetString(bTitle));
            string authorName = HttpUtility.UrlDecode(Encoding.UTF8.GetString(bAuthorName));
            string genre = HttpUtility.UrlDecode(Encoding.UTF8.GetString(bGenre));

            List<Book> filteredBooks = new List<Book>();

            foreach (Book book in (List<Book>)Session["bookList"])
            {
                bool bookGenre = false;
                foreach (Genre genreEnum in book.Genres)
                {
                    if (genreEnum.ToString().ToLower().Contains(genre))
                        bookGenre = true;
                }
                if (book.Title.ToLower().Contains(title) &&
                    book.Author.Name.ToLower().Contains(authorName) &&
                    (bookGenre || string.IsNullOrEmpty(genre)))
                    filteredBooks.Add(book);
            }

            GridViewSearchResult.DataSource = filteredBooks;
            GridViewSearchResult.DataBind();
        }

        protected void GridViewSearchResult_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableCell author = e.Row.Cells[0];
                TableCell title = e.Row.Cells[1];

                string strAuthor = HttpUtility.UrlEncode(author.Text);
                string encodedAuthor = HttpServerUtility.UrlTokenEncode((Encoding.UTF8.GetBytes(strAuthor)));

                string strTitle = HttpUtility.UrlEncode(title.Text);
                string encodedTitle = HttpServerUtility.UrlTokenEncode((Encoding.UTF8.GetBytes(strTitle)));

                author.Controls.Clear();
                author.Controls.Add(new HyperLink
                {
                    NavigateUrl = $"AuthorForm.aspx?name={encodedAuthor}",
                    Text = author.Text
                });

                title.Controls.Clear();
                title.Controls.Add(new HyperLink
                {
                    NavigateUrl = $"BookForm.aspx?title={encodedTitle}",
                    Text = title.Text
                });
            }


        }
    }
}