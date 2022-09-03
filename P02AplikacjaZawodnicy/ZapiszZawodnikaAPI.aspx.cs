using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class ZapiszZawodnikaAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"]);
                string imie = Request["imie"];
                string nazwisko = Request["nazwisko"];
                string kraj = Request["kraj"];
                string miasto = Request["miasto"];
                int waga = Convert.ToInt32(Request["waga"]);
                int wzrost = Convert.ToInt32(Request["wzrost"]);
                DateTime dataur = Convert.ToDateTime(Request["dataUr"]);

                ZawodnicyRepository zr = new ZawodnicyRepository();

                ZawodnikVM zvm = new ZawodnikVM()
                {
                    Imie = imie,
                    Nazwisko = nazwisko,
                    Kraj = kraj,
                    DataUr = dataur,
                    Miasto = miasto,
                    Waga = waga,
                    Wzrost = wzrost,
                    Id_zawodnika = id
                };
                zr.Edytuj(zvm);
            }
            catch (Exception)
            {
                Response.Redirect("error.aspx");
            }
        }
    }
}