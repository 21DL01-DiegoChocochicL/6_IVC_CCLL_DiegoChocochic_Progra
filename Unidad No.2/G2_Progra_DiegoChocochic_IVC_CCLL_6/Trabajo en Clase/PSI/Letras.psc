Algoritmo Letras
	// Ingresa una letra: A = Excelente, B = Bueno, C = Regular, D = Deficiente, F = Reprobado
	// Inicio
	Definir nota, decena Como Entero
	Definir nombreClase Como Cadena
	Escribir '\t* Menu'
	Escribir '\t**********************************************'
	Escribir '\t* Lista de Letras         *'
	Escribir '\t* A- Exelentes                                   *'
	Escribir '\t* B- Bueno                                 *'
	Escribir '\t* C- Regular                               *'
	Escribir '\t* D- Deficiente                               *'
	Escribir '\t* F- Reprobado                               *'
	Escribir ' \t**********************************************'
	Escribir 'Dígame su nota (0-100):'
	Leer nota
	Escribir 'Dígame la clase:'
	Leer nombreClase
	// Proceso
	decena <- Trunc(nota/10)
	// Salida
	Escribir 'Resultado para la clase de ', nombreClase, ':'
	// Sentencia de Seleccion
	Según decena Hacer
		10, 9:
			Escribir 'Obtuviste una A'
		8:
			Escribir 'Obtuviste una B'
		7:
			Escribir 'Obtuviste una C'
		6:
			Escribir 'Obtuviste una D'
		De Otro Modo:
			Escribir 'Obtuviste una F'
	FinSegún
FinAlgoritmo
