// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function validarNroTarjeta() {

	
	var numero = document.getElementById('numeroTarjeta');

	
	var valido = "^[0-9]{16,16}$";

	// Using test we can check if the text match the pattern
	if (valido.test(numero.value)) {
		alert('OK');
		return true;
	} else {
		alert('error en el numero de tarjeta');
		return false;
	}
} 
