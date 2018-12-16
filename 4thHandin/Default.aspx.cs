using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4Handin
{
    public partial class _Default : Page
    {
        private object Repeater2;

        public object TextBox1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater2.DataSource = FourthProjectLogic.Movie.MovieTableAdapter.MoviesTop10();
            Repeater2.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e) => FourthProjectLogic.SearchMovies(TextBox1.Text);
    }
}