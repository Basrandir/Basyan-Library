using BLLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basyan_Library
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            string password = TxtPassword.Text;

            if (LoginHelper.IsAuthentic(username, password))
            {
                string roles = LoginHelper.GetUserRole(username);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddDays(1), false, roles);

                string strTicket = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, strTicket));

                Response.Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            }
            else
            {
                lblStatus.Text = "Invalid username or password";
            }
        }
    }
}