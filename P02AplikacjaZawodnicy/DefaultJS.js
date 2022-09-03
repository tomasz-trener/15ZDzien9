$(document).ready(function () {
    $.ajax({
        method: "POST",
        url: "ZawodnicyAPI.aspx",
        // data: { liczba1Klucz: liczba1, liczba2: liczba2 }
    })
        .done(function (msg) {
            // alert("Data Saved: " + msg);
            $(".col-md-12").html(msg);
        });
});