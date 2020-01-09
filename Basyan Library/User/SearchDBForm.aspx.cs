using BLLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Basyan_Library
{
    public partial class SearchDBForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string strtitle = HttpUtility.UrlEncode(TxtTitle.Text);
            string strAuthorName = HttpUtility.UrlEncode(TxtAuthorName.Text);
            string strGenre = HttpUtility.UrlEncode(TxtGenre.Text);

            string encodedTitle = HttpServerUtility.UrlTokenEncode((Encoding.UTF8.GetBytes(strtitle)));
            string encodedAuthorName = HttpServerUtility.UrlTokenEncode((Encoding.UTF8.GetBytes(strAuthorName)));
            string encodedGenre = HttpServerUtility.UrlTokenEncode((Encoding.UTF8.GetBytes(strGenre)));

            Response.Redirect($"SearchResult.aspx?title={encodedTitle}&author={encodedAuthorName}&genre={encodedGenre}");
        }
    }
}