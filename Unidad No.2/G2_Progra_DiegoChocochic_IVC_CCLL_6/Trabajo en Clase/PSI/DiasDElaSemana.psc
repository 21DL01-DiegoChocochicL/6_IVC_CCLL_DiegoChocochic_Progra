Algoritmo DiasDElaSemana
	// Solicita un número del 1 al 7 y muestra el día correspondiente.
	// Inicio
	Definir num Como Entero
	Escribir '\t* Menu'
	Escribir '\t**********************************************'
	Escribir '\t* Lista de Días de la Semana                 *'
	Escribir '\t* 1- Lunes                                   *'
	Escribir '\t* 2- Martes                                  *'
	Escribir '\t* 3- Miércoles                               *'
	Escribir '\t* 4- Jueves                                  *'
	Escribir '\t* 5- Viernes                                 *'
	Escribir '\t* 6- Sábado                                  *'
	Escribir '\t* 7- Domingo                                 *'
	Escribir '\t**********************************************'
	Escribir 'Digame le dia de la semana en numero (1-7): '
	Leer num
	// Sentencia dde Selección y Salida
	Según num Hacer
		1:
			Escribir 'Es Lunes'
		2:
			Escribir 'Martes'
		3:
			Escribir 'Miercoles'
		4:
			Escribir 'Jueves'
		5:
			Escribir 'Viernes'
		6:
			Escribir 'Sabado'
		7:
			Escribir 'Sabado'
		De Otro Modo:
			Escribir 'El numero que coloco no en el rango establrecido (1-7)'
	FinSegún
FinAlgoritmo
