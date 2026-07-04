Algoritmo Estadio
	// El Estadio Doroteo Guamuch Flores es uno de los estadios más importantes de Centroamérica. Este
	// estadio tiene diversos sectores, el costo de la entrada a los eventos futbolísticos del estadio se asignan en
	// virtud de los sectores del estadio mediante la siguiente lista:
	// -Palco: Q300.00
	// -Tribuna: Q100.00 - Q125.00
	// -Preferencia: Q50.00 - Q75.00
	// -Generales: Q30.00 - Q50.00
	// Se pide construir un programa que permita seleccionar un sector del estadio, ingresar la cantidad de
	// entradas solicitadas y calcular el total a pagar por las entradas
	// Inicio
	Definir s, c, t Como Real
	Escribir '\t* Estadio Doroteo Guamuch Flores'
	Escribir '\t**********************************************'
	Escribir '\t* Precios          *'
	Escribir '\t* 1- Palco: Q300.00*'
	Escribir '\t* 2- Tribuna: Q100.00 - Q125.00*'
	Escribir '\t* 3- Preferencia: Q50.00 - Q75.00 *'
	Escribir '\t* 4- Generales: Q30.00 - Q50.00*'
	Escribir '\t**********************************************'
	Escribir 'Cual Sector prefiere:'
	Leer s
	Escribir 'Cuantos boletos necesita: '
	Leer c
	// Sentencia de Seleccion, Proceso y Salida
	Según s Hacer
		1:
			Escribir 'Ok, necesita ', c, ' boletos, en el sector, Palco, el total seria, ', (c*300.00), 'Q'
		2:
			Escribir 'Ok, necesita ', c, ' boletos, en el sector, Tribuna, el total seria, ', (c*100.00), 'Q', ' a ', (c*125.00), 'Q'
		3:
			Escribir 'Ok, necesita ', c, ' boletos, en el sector, Preferencia, el total seria, ', (c*50.00), 'Q', ' a ', (c*75.00), 'Q'
		4:
			Escribir 'Ok, necesita ', c, ' boletos, en el sector, Generales, el total seria, ', (c*30.00), 'Q', ' a ', (c*50.00), 'Q'
		De Otro Modo:
			Escribir 'Valor no valido'
	FinSegún
FinAlgoritmo
