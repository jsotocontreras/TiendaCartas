function openNav() {
    var x = document.forms["myForm"]["fname"].value;
    if (x == null || x == "") {
        alert("Debe ingresar datos en el sistema de búsqueda");
        return false
    }
    else
        document.getElementById("mySidenav").style.width = "20%";
    return false
}


function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}