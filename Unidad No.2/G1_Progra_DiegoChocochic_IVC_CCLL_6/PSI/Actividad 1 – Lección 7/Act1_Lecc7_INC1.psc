Algoritmo Act1_Lecc7_INC1
	// Entrada
	Escribir 'Promedio de Calificaciones'
	Definir M Como Cadena
	Definir n1, n2, n3, n4, n5, Prom Como Real
	Escribir 'Escriba la Materia: '
	Leer M
	Escribir 'Dame las 5 notas de la Materia: '
	Leer n1
	Leer n2
	Leer n3
	Leer n4
	Leer n5
	// Proceso
	Prom <- (n1+n2+n3+n4+n5)/5
	// Evaluar
	Si Prom>=70 Entonces
		Escribir 'El alumno ha ganado la clase ', M, ' con un Promedio de: ', Prom, 'Pts'
	SiNo
		Escribir 'El alumno ha Perdido la clase ', M, ' con un Promedio: ', Prom, 'Pts'
	FinSi
FinAlgoritmo
