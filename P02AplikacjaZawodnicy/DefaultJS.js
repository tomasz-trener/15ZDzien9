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
                pokazSzczegoly();
            });
        });
}

function pokazLadowanie() {
    var obrazek = $("#dvLadowanie").html();
    $(".col-md-12").html(obrazek);
}

function pokazSzczegoly() {
    pokazLadowanie();
    $.ajax({
        method: "POST",
        url: "EdycjaZawodnika.aspx",
        // data: { filtr: filtr }
    })
        .done(function (msg) {
            // alert("Data Saved: " + msg);
            $(".col-md-12").html(msg);
        });
}