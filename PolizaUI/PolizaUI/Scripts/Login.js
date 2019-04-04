function ValidarUser()
{

};
function controlEspacio() {

    var evento_key = window.event.keyCode;
    if (evento_key == '32') //comparo tecla space
    {
        alert("No se pueden usar espacios");
        return false;


    }
    else {
        return true;
    }

};
function setCookie(name, value) {
    var today = new Date();
    var expiry = new Date(today.getTime() + 30 * 24 * 3600 * 1000); // plus 30 days
    document.cookie = name + "=" + escape(value) + "; path=/; expires=" + expiry.toGMTString();
};
function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
};
function guardarPass(){
    var cck = document.getElementById("chk").checked
    if (cck) {
        var pass = $("#ContentPlaceHolder1_txt_P").val();
        setCookie("pass", pass);
        var Cpass = getCookie("pass");
        return Cpass;
        }
};
function GuardarUser() {
    var cck = document.getElementById("chk").checked
    if (cck) {
        var user = $("#ContentPlaceHolder1_txt_U").val();
        setCookie("user", user);
        var Cuser = getCookie("user");
        return Cuser;
    }
};
function imprimirCookkies() {
    var cck = document.getElementById("chk").checked
    if (cck) {
        var user = GuardarUser(user);
        var pass = guardarPass(pass);
    }
    else
    {
        user = "";
        pass = "";
    }
    $("#ContentPlaceHolder1_txt_U").val(user);
};
