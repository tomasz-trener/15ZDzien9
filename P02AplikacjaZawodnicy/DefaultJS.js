$(document).ready(function () {
    wyslijNaSerwer();

    $(".input-group-append").click(function () {
        wyslijNaSerwer();
    });
});

function wyslijNaSerwer() {
    pokazLadowanie();
    var filtr = $("#txtFiltr").val();
    $.ajax({
        method: "POST",
        url: "ZawodnicyAPI.aspx",
        data: { filtr: filtr }
    })
        .done(function (msg) {
            // alert("Data Saved: " + msg);
            $(".col-md-12").html(msg);

            $("tr").click(function () {
                var id = $(this).data('id');
                pokazSzczegoly(id);
            });
        });
}

function pokazLadowanie() {
    var obrazek = $("#dvLadowanie").html();
    $(".col-md-12").html(obrazek);
}

function pokazSzczegoly(id) {
    pokazLadowanie();
    $.ajax({
        method: "POST",
        url: "EdycjaZawodnika.aspx",
        data: { id: id }
    })
        .done(function (msg) {
            // alert("Data Saved: " + msg);
            $(".col-md-12").html(msg);

            $("#btnZapisz").click(function () {
                var imie = $("#txtImie").val();
                var nazwisko = $("#txtImie").val();
                var kraj = $("#txtKraj").val();
                var miasto = $("#txtMiasto").val();
                var waga = $("#txtWaga").val();
                var wzrost = $("#txtWzrost").val();
                var dataUr = $("#txtDataUr").val();

                data = {
                    imie: imie,
                    nazwisko: nazwisko,
                    kraj: kraj,
                    miasto: miasto,
                    waga: waga,
                    wzrost: wzrost,
                    dataUr: dataUr
                };

                zapiszZawodnika(data);
            });
        });
}

function zapiszZawodnika(data) {
    $.ajax({
        method: "POST",
        url: "ZapiszZawodnikaAPI.aspx",
        data: data
    })
        .done(function (msg) {
            alert("Data Saved: " + msg);
        });
}