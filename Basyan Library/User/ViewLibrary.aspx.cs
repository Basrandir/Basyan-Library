using BLLibrary;
using BLLibrary.DAL;
using BLLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basyan_Library
{
    public partial class ViewLibrary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentUser = null;

            List<User> users = (List<User>) Session["userList"];

            foreach(User user in users)
            {
                if(user.Username.Equals(Context.User.Identity.Name))
                {
                    currentUser = user;
                    break;
                }
            }

            if (!IsPostBack)
            {
                foreach (KeyValuePair<Book, int> book in currentUser.Library)
                {
                    TableRow row = new TableRow();
                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();

                    string strTitle = HttpUtility.UrlEncode(book.Key.Title);
                    string encodedTitle = HttpServerUtility.UrlTokenEncode((Encoding.UTF8.GetBytes(strTitle)));

                    cell1.Controls.Add(new HyperLink
                    {
                        NavigateUrl = $"BookForm.aspx?title={encodedTitle}",
                        Text = book.Key.Title
                    });

                    cell2.Text = book.Value.ToString();

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);

                    tblLibrary.Rows.Add(row);
                }
            }
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchDBForm.aspx");
        }
    }
}