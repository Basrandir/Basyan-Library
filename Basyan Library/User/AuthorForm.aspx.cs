using BLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basyan_Library
{
    public partial class AuthorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string encodedAuthor = Request.QueryString["name"];
            byte[] bAuthor = HttpServerUtility.UrlTokenDecode(encodedAuthor);
            string authorName = HttpUtility.UrlDecode(Encoding.UTF8.GetString(bAuthor));

            List<Author> authors = (List<Author>) Session["authorList"];
            foreach(Author author in authors)
            {
                if (author.Name.Equals(authorName))
                {
                    LblShowAuthorName.Text = author.Name;
                    LblShowCountry.Text = author.Country;
                    LblShowDOB.Text = author.Dob.ToString();
                }
            }
        }
    }
}