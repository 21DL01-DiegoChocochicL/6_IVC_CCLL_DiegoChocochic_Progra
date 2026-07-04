Algoritmo DterminarCaracter
	// El siguiente programa determina si un carácter ingresado por el usuario es vocal, digito o ninguno de
	// los anteriores.
	// Inicio
	Definir c Como Cadena
	Escribir 'Escriba un caracter:'
	Leer c
	// Sentencia de Seleccion, Proceso y Salida
	Según c Hacer
		'a', 'e', 'i', 'o', 'u':
			Escribir 'El carácter ingresado es una vocal.'
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9':
			Escribir 'El carácter ingresado es un digito.'
		De Otro Modo:
			Escribir 'El carácter no es ni vocal ni dígito.'
	FinSegún
FinAlgoritmo
