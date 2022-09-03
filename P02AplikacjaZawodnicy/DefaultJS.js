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
        });
}