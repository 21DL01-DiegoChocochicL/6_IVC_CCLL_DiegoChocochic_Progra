Algoritmo Lecc32_Act_1_Inc1
	// Crea un nuevo programa en C# que reciba una cantidad en metros y muestre un menu de opciones, el cual
	// pregunte si quiere convertir a: mm,cm,dcm,hcm,klm
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Conversiones'
	Definir metros, resultado Como Real
	Definir opcion, unidad Como Cadena
	Escribir 'Ingrese la cantidad en metros:'
	Leer metros
	Escribir ''
	Escribir 'Menú de opciones. Convertir a:'
	Escribir 'a. Milímetros'
	Escribir 'b. Centímetros'
	Escribir 'c. Decímetros'
	Escribir 'd. Hectómetros'
	Escribir 'e. Kilómetros'
	Escribir 'Seleccione una opción (a-e):'
	Leer opcion
	Según opcion Hacer
		'a', 'A':
			resultado <- metros*1000
			unidad <- 'milímetros'
		'b', 'B':
			resultado <- metros*100
			unidad <- 'centímetros'
		'c', 'C':
			resultado <- metros*10
			unidad <- 'decímetros'
		'd', 'D':
			resultado <- metros/100
			unidad <- 'hectómetros'
		'e', 'E':
			resultado <- metros/1000
			unidad <- 'kilómetros'
		De Otro Modo:
			Escribir 'Opción no válida.'
			unidad <- ''
	FinSegún
	Si unidad<>'' Entonces
		Escribir metros, ' metros equivale a ', resultado, ' ', unidad, '.'
	FinSi
FinAlgoritmo
