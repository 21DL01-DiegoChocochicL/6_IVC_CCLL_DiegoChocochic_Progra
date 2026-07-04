Algoritmo Meses
	// Pide un número del 1 al 12 y muestra el mes correspondiente, Indica también cuántos días tiene el
	// mes
	// Inicio
	Definir num Como Entero
	Escribir '\t* Menu'
	Escribir '\t**********************************************'
	Escribir '\t* Lista de Meses del Año                     *'
	Escribir '\t* 1- Enero                                   *'
	Escribir '\t* 2- Febrero                                 *'
	Escribir '\t* 3- Marzo                                   *'
	Escribir '\t* 4- Abril                                   *'
	Escribir '\t* 5- Mayo                                    *'
	Escribir '\t* 6- Junio                                   *'
	Escribir '\t* 7- Julio                                   *'
	Escribir '\t* 8- Agosto                                  *'
	Escribir '\t* 9- Septiembre                              *'
	Escribir '\t* 10- Octubre                                *'
	Escribir '\t* 11- Noviembre                              *'
	Escribir '\t* 12- Diciembre                              *'
	Escribir '\t**********************************************'
	Escribir 'Digame un numero del 1 al 12 para saber cuantos días tiene: '
	Leer num
	// Proceso, Salida y Sentencia Seleccion
	Según num Hacer
		1:
			Escribir 'Enero: 31 días'
		2:
			Escribir 'Febrero: 28 días (29 días en año bisiesto)'
		3:
			Escribir 'Marzo: 31 días'
		4:
			Escribir 'Abril: 30 días'
		5:
			Escribir 'Mayo: 31 días'
		6:
			Escribir 'Junio: 30 días'
		7:
			Escribir 'Julio: 31 días'
		8:
			Escribir 'Agosto: 31 días'
		9:
			Escribir 'Septiembre: 30 días'
		10:
			Escribir 'Octubre: 31 días'
		11:
			Escribir 'Noviembre: 30 días'
		12:
			Escribir 'Diciembre: 31 días'
		De Otro Modo:
			Escribir 'Numero no Valido'
	FinSegún
FinAlgoritmo
