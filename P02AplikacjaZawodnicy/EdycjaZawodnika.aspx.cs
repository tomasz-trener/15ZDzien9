using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class EdycjaZawodnika : System.Web.UI.Page
    {
        public ZawodnikVM Zawodnik;

        protected void Page_Load(object sender, EventArgs e)
        {
            string idString = Request["id"];
            int id;

            if (!int.TryParse(idString, out id))
                Response.Redirect("Error.aspx");
            else if (id > 0)
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                Zawodnik = zr.WczytajZawodnika(id);
                txtImie.Text = Zawodnik.Imie;
                txtNazwisko.Text = Zawodnik.Nazwisko;
                txtKraj.Text = Zawodnik.Kraj;
                txtMiasto.Text = Zawodnik.Miasto;
                txtWaga.Text = Zawodnik.Waga.ToString();
                txtWzrost.Text = Zawodnik.Wzrost.ToString();
                txtDataUr.Text = Zawodnik.DataUr?.ToString("dd-MM-yyyy");
                //btnUsun.Visible = true;
            }
        }
    }
}