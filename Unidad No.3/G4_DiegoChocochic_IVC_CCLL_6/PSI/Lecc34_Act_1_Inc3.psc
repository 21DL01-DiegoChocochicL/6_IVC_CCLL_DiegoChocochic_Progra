Algoritmo Lecc34_Act_1_Inc3
	// Recibe una cantidad en grados centigrados y la convierte a: a.Fahrenheit;b.Celcius;c.Kelvin
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Convercion de Grados'
	Definir celsius, resultado Como Real
	Definir opcion, unidad Como Cadena
	Escribir 'Ingrese la cantidad en grados centígrados:'
	Leer celsius
	Escribir ''
	Escribir 'Convertir a:'
	Escribir 'a. Fahrenheit'
	Escribir 'b. Celsius (Misma escala)'
	Escribir 'c. Kelvin'
	Escribir 'Seleccione una opción:'
	Leer opcion
	Según opcion Hacer
		'a', 'A':
			resultado <- (celsius*9/5)+32
			unidad <- 'grados Fahrenheit (°F)'
		'b', 'B':
			resultado <- celsius
			unidad <- 'grados Celsius (°C)'
		'c', 'C':
			resultado <- celsius+273.15
			unidad <- 'Kelvin (K)'
		De Otro Modo:
			Escribir 'Opción no válida.'
			unidad <- ''
	FinSegún
	Si unidad<>'' Entonces
		Escribir ''
		Escribir celsius, ' grados centígrados equivale a ', resultado, ' ', unidad, '.'
	FinSi
FinAlgoritmo
