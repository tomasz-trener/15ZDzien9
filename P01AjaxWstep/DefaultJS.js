$(document).ready(function () {
    $("#btnPoliczHTML").click(function () {
        var liczba1 = $("#txtLiczba1HTML").val();
        var liczba2 = $("#txtLiczba2HTML").val();

        //  var liczba3 = parseInt(liczba1) + parseInt(liczba2);
        //   $("#lblWynikHTML").html(liczba3);

        $.ajax({
            method: "POST",
            url: "DefaultAPI.aspx",
            data: { liczba1Klucz: liczba1, liczba2: liczba2 }
        })
            .done(function (msg) {
                // alert("Data Saved: " + msg);
                $("#lblWynikHTML").html(msg);
            });
    });
});