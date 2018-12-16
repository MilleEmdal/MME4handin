using System;

namespace _4thHandin
{
    public partial class Browse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.ConnectionString = FourthProjectLogic.ConnStr;

            //if no genre querystring, default to action movies
            if (string.IsNullOrWhiteSpace(Request.QueryString["genre"]))
            {
                Repeater1.DataSource = FourthProjectLogic.Movie.MovieTableAdapter.GetDataByGenre("Action");
            }
            else //use querystring
            {
                Repeater1.DataSource = FourthProjectLogic.Movie.MovieTableAdapter.GetDataByGenre(Request.QueryString["genre"]);
            }
            Repeater1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //navigate to page with querystring after selection               
            Response.Redirect("~/browse/?genre=" + DropDownList1.SelectedValue);
        }
    }
}