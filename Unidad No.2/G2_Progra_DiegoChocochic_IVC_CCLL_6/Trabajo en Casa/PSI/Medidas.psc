Algoritmo Medidas
	// Elabore un conversor de medidas de longitud. El usuario podrá elegir entre las siguientes unidades de
	// medida: - a) Metros - b) Pies - c) Centímetros - d) Pulgadas
	// Inicio
	Definir n Como Real
	Definir m Como Cadena
	Escribir '	* Menu'
	Escribir '	**********************************************'
	Escribir '	* Lista de Unidades de Medida              *'
	Escribir '	* a- Metros                                *'
	Escribir '	* b- Pies                                  *'
	Escribir '	* c- Centímetros                           *'
	Escribir '	* d- Pulgadas                              *'
	Escribir '	**********************************************'
	Escribir 'Digame un numero: '
	Leer n
	Escribir 'Seleccione una media del Menu: '
	Leer m
	// Sentencia de Seleccion, Proceso y Salida
	Según m Hacer
		'a', 'A':
			Escribir 'La conversion es, ', n, ' Metros'
		'b', 'B':
			Escribir 'La conversion es, ', n, ' Pies'
		'c', 'C':
			Escribir 'La conversion es, ', n, ' Centimetros'
		'd', 'D':
			Escribir 'La conversion es, ', n, ' Pulgadas'
		De Otro Modo:
			Escribir 'Numero no Valido'
	FinSegún
FinAlgoritmo
