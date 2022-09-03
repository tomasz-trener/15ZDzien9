using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class UsunZawodnikaAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"]);

                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.UsunZawodnika(new ZawodnikVM() { Id_zawodnika = id });
            }
            catch (Exception)
            {
                Response.Redirect("error.aspx");
            }
        }
    }
}