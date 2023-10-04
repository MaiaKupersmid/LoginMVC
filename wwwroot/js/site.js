// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//document.addEventListener("DOMContentLoaded", () => {

/*opcion 1: usando onsubmit
function checkForm()
{
    alert("ceckform");
    const contraseña1 = document.getElementById("Contraseña1");

    const especiales = ["#", "$", "%", "&", "/", "@"];
    Contraseña1.includes(especiales);
    
    const contraseña2 = document.getElementById("Contraseña2");

}

*/


//opcion 2: escuchar cuando escribe algo

document.getElementsById("Contrasena1").addEventListener('keypress', () =>
{
    const contrasena1 = document.getElementById("Contrasena1");

    const especiales = ["#", "$", "%", "&", "/", "@"];
    Contrasena1.includes(especiales);
    
    const contrasena2 = document.getElementById("Contrasena2");
}
);
