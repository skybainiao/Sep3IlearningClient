
    function myFunction(id) {
    var x = document.getElementById(id);
    if (x.className.indexOf("w3-show") == -1) {
    x.className += " w3-show";
} else {
    x.className = x.className.replace(" w3-show", "");
}
}


    $("[name='sexRadio']:eq(0)").parent("span").addClass("checked");
    $("[name='sexRadio']:eq(0)").prop("checked",true);



    function getRadio(){
    var c = $('input:radio[name="sexRadio"]:checked').val();
    var b = $('input[name="sexRadio"]:checked').val();
    alert(c);
}
