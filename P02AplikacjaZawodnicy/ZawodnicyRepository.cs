using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy
{
    internal class ZawodnicyRepository
    {
        public ZawodnikVM[] WczytajZawodnikow(string filtr, string sortowanie)

        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            var zapytanie =
                db.Zawodnik.Where(x =>
                    x.kraj.Contains(filtr) ||
                    x.imie.Contains(filtr) ||
                    x.nazwisko.Contains(filtr)
                    );

            if (!string.IsNullOrEmpty(sortowanie))
            {
                sortowanie = sortowanie.ToLower();

                // var pi = typeof(Zawodnik).GetProperty(sortowanie);
                // zapytanie = zapytanie.OrderBy(x => pi.GetValue(x, null));

                //zapytanie = zapytanie.OrderBy(x => x.GetType().GetProperty(sortowanie).GetValue(x));

                if (sortowanie == "imie")
                    zapytanie = zapytanie.OrderBy(x => x.imie);

                if (sortowanie == "nazwisko")
                    zapytanie = zapytanie.OrderBy(x => x.nazwisko);

                if (sortowanie == "wzrost")
                    zapytanie = zapytanie.OrderBy(x => x.wzrost);
            }

            Zawodnik[] zawodnicyDb = zapytanie.ToArray();

            var wynik =
            zawodnicyDb.Select(x => Transformuj(x)).ToArray();

            return wynik;
        }

        private ZawodnikVM Transformuj(Zawodnik x)
        {
            return new ZawodnikVM()
            {
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                Kraj = x.kraj,
                DataUr = x.data_ur,
                Waga = x.waga == null ? 0 : (int)x.waga,
                Wzrost = x.wzrost == null ? 0 : (int)x.wzrost,
                Miasto = x.miasto,
                Id_trenera = x.id_trenera,
                Id_zawodnika = x.id_zawodnika
            };
        }

        public void Edytuj(ZawodnikVM zawodnik)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var zdb = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == zawodnik.Id_zawodnika);
            zdb.id_trenera = zawodnik.Id_trenera;
            zdb.imie = zawodnik.Imie;
            zdb.nazwisko = zawodnik.Nazwisko;
            zdb.miasto = zawodnik.Miasto;
            zdb.kraj = zawodnik.Kraj;
            zdb.waga = zawodnik.Waga;
            zdb.wzrost = zawodnik.Wzrost;
            zdb.data_ur = zawodnik.DataUr;
            db.SubmitChanges();
        }

        internal void DodajZawodnika(ZawodnikVM zawodnik)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            Zawodnik nowy = new Zawodnik()
            {
                id_trenera = zawodnik.Id_trenera,
                imie = zawodnik.Imie,
                nazwisko = zawodnik.Nazwisko,
                miasto = zawodnik.Miasto,
                kraj = zawodnik.Kraj,
                waga = zawodnik.Waga,
                wzrost = zawodnik.Wzrost,
                data_ur = zawodnik.DataUr,
            };

            db.Zawodnik.InsertOnSubmit(nowy);
            db.SubmitChanges();
        }

        public void UsunZawodnika(ZawodnikVM zawodnik)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doUsuniecia =
                db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == zawodnik.Id_zawodnika);

            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();
        }

        public ZawodnikVM WczytajZawodnika(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var z = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);
            return Transformuj(z);
        }
    }
}