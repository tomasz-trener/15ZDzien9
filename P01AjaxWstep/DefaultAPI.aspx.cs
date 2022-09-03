using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AjaxWstep
{
    public partial class DefaultAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s1 = Request["liczba1Klucz"];
            string s2 = Request["liczba2"];

            int liczba3 = Convert.ToInt32(s1) +
                Convert.ToInt32(s2);

            Response.Write(liczba3);

            //string n = "ala ma kota!";

            //Response.Write(n);
        }
    }
}