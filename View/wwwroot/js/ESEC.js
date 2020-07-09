
function test(){
    var otro = parseInt( document.getElementById("Otro").value);
    var Alimentacion = parseInt(document.getElementById("Alimentacion").value);
    var Servicios = parseInt(document.getElementById("Servicios").value);
    var Vivienda = parseInt(document.getElementById("Vivienda").value);
    var Escolaridad = parseFloat(document.getElementById("Escolaridad").value)
    var Transporte = parseFloat(document.getElementById("Transporte").value)

    var Egresos = otro + Alimentacion + Servicios + Vivienda + Transporte + Escolaridad;

    document.getElementById('Egresos').value = parseInt(Egresos);
}

function Save(){
    var Egresos = parseInt(document.getElementById('Egresos').value);
    var Ingresos = parseInt(document.getElementById('Ingresos').value);

    if(Egresos > Ingresos)
        alert("Los Egresos no pueden ser mayores a los ingresos, Vuelva al apartado de Informacion socio economica");
    
}