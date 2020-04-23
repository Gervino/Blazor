function saveMessage(fname, lname) {

    fname = fname != null ? fname : "---"
    lname =lname != null ? lname : "---"
    var mess = "First Name : " + fname + " Last Name : " + lname;
    //alert(mess != null ? mess : "");

    document.getElementById('divServerValidations').innerText = mess;
}

function setFocusOnElement(element) {
    console.log("element ok", element)
    element.focus();
}