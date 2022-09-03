$(document).ready(function () {
    wyslijNaSerwer();

    $(".input-group-append").click(function () {
        wyslijNaSerwer();
    });
});

function wyslijNaSerwer() {
    var filtr = $("#txtFiltr").val();
    $.ajax({
        method: "POST",
        url: "ZawodnicyAPI.aspx",
        data: { filtr: filtr }
    })
        .done(function (msg) {
            // alert("Data Saved: " + msg);
            $(".col-md-12").html(msg);
        });
}