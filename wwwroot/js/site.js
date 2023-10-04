// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//document.addEventListener("DOMContentLoaded", () => {

/*
opcion 1: usando onsubmit
function checkForm()
{
    alert("ceckform");
    const contraseña1 = document.getElementById("Contraseña1");

    const especiales = ["#", "$", "%", "&", "/", "@"];
    Contraseña1.includes(especiales);
    
    const contraseña2 = document.getElementById("Contraseña2");

}

opcion 2: escuchar cuando escribe algo

document.getElementById("Contrasena1").addEventListener('keypress', () =>
{
    const especiales = ["#", "$", "%", "&", "/", "@"];
    console.log(Contrasena1.includes(especiales));

});

document.getElementById("Contrasena2").addEventListener('keypress', (event) => {
});
*/

document.getElementById("Contrasena1").addEventListener('keyup', (event) => {
    const contra1 = document.getElementById("Contrasena1")
    const especiales = ["#", "$", "%", "&", "/", "@"];
    const mayus = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
    const contrasena1 = document.getElementById("Contrasena1").value;
    const contieneEspeciales = especiales.some(caracter => contrasena1.includes(caracter));
    const contieneMayus = mayus.some(caracter => contrasena1.includes(caracter));

    let ok = false;
    if (contieneEspeciales && contieneMayus && contrasena1.length >= 8) {
        contra1.style.border = "2px solid green";
        ok = true;
    } else {
        contra1.style.border = "2px solid red"
    }
});

document.getElementById("Contrasena2").addEventListener('keyup', (event) => {
    const contra2 = document.getElementById("Contrasena2")
    const contrasena1 = document.getElementById("Contrasena1").value;
    const contrasena2 = document.getElementById("Contrasena2").value;
    let ok2 = false;

    if (contrasena1 === contrasena2) {
        contra2.style.border = "2px solid green";
        ok2 = true;
    } else {
        contra2.style.border = "2px solid red";
    }

});
