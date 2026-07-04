Algoritmo Funciones
	// Crear una calculadora de funciones trigonométricas, dado un ángulo ingresado por el usuario (en grados)
	// se debe calcular a una de las 3 funciones trigonométricas básicas.
	// Inicio
	Definir g, r, resultado Como Real
	Definir op Como Entero
	Escribir '\t* CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS'
	Escribir '\t**********************************************'
	Escribir '\t* Lista de funciones trigonometricas          *'
	Escribir '\t* 1- Seno                                   *'
	Escribir '\t* 2- Coseno                                 *'
	Escribir '\t* 3- Tangente                               *'
	Escribir ' \t**********************************************'
	Escribir 'Ingresa el angulo:'
	Leer g
	Escribir 'Selecciona una funcion: '
	Leer op
	// Proceso
	r <- g*(PI/180)
	// Sentencia de Seleccion, Proceso y Salida
	Según op Hacer
		1:
			resultado <- sen(r)
			Escribir 'El Seno de ', g, ' grados es: ', resultado
		2:
			resultado <- cos(r)
			Escribir 'El Coseno de ', g, ' grados es: ', resultado
		3:
			Si cos(r)<0.000001 Y cos(r)>-0.000001 Entonces
				Escribir 'Error: La tangente no esta definida para este angulo.'
			SiNo
				resultado <- tan(r)
				Escribir 'La Tangente de ', g, ' grados es: ', resultado
			FinSi
		De Otro Modo:
			Escribir 'Opcion no valida.'
	FinSegún
FinAlgoritmo
