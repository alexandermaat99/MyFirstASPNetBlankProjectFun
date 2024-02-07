$("#btnSubmit").click(function () {
    alert("From=" + $("#txtFrom").val() +
        ", Subject=" + $("#txtSubject").val() +
        ", Message=" + $("#txtMessage").val());

    $("#imgHilton").fadeOut("slow");
});